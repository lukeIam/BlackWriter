using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PlistCS;

namespace BlackWriter
{
    public class Set : IDisposable
    {
        private readonly Dictionary<Guid, Case> _cases = new Dictionary<Guid, Case>();
        private readonly DirectoryInfo _tempPack;
        private readonly string _tempSessionPath = Path.GetTempPath() + "BlackWriter\\" + Guid.NewGuid() + "\\";

        public string DetailDescription { get; set; }
        public string EditionName { get; set; }
        public string Locale { get; set; }
        public string Subtitle { get; set; }
        public string Uuid { get; private set; }

        public List<Case> Cases
        {
            get { return _cases.Values.ToList(); }
        }

        private string PackageFileName
        {
            get { return Uuid; }
        }

        public Image Cover
        {
            get
            {
                FileInfo cover =
                    new FileInfo(Path.Combine(_tempPack.FullName, CoverFileName + "." + CoverFileExtension));
                if (!cover.Exists)
                {
                    return null;
                }

                Image resultImg;
                using (Image img = Image.FromFile(cover.FullName))
                {
                    resultImg = new Bitmap(img);
                }

                return resultImg;
            }

            set
            {
                FileInfo cover =
                    new FileInfo(Path.Combine(_tempPack.FullName, CoverFileName + "." + CoverFileExtension));
                if (cover.Exists)
                {
                    cover.Delete();
                }

                value.Save(cover.FullName);
            }
        }

        private string PackageFileExtension
        {
            get { return "tdsBook"; }
        }
        private string InAppPurchaseID
        {
            get { return ""; }
        }
        private string ImageFolder
        {
            get { return "images"; }
        }
        private string ImageFileExtension
        {
            get { return "png"; }
        }
        private string CoverFileName
        {
            get { return "Cover"; }
        }
        private string CoverFileExtension
        {
            get { return "png"; }
        }
        private bool IsPreinstalled { get { return false; } }
        private bool IsRatingEnabled { get { return false; } }

        public void AddCase(Case c)
        {
            Guid id = new Guid(c.Uuid);
            if (_cases.Keys.Contains(id))
            {
                _cases.Remove(id);
            }

            _cases.Add(id, c);
        }

        public void RemoveCase(Case c)
        {
            Guid id = new Guid(c.Uuid);
            if (_cases.Keys.Contains(id))
            {
                _cases.Remove(id);
            }
        }

        public void RemoveCase(Guid id)
        {
            if (_cases.Keys.Contains(id))
            {
                _cases.Remove(id);
            }
        }

        private Dictionary<string, string>[] CasesToArray()
        {
            return _cases.Values.Select(c => c.ToDictionary()).ToArray();
        }

        private Dictionary<string, object> MetadataToDictionary()
        {
            return new Dictionary<string, object>
            {
                {"TDSEditionPackageContentTypes", new string[]{"BSCardGame"}},
                {"coverFileExtension", CoverFileExtension},
                {"coverFileName", CoverFileName},
                {"detailDescription", DetailDescription},
                {"editionName", EditionName},
                {"imageFileExtension", ImageFileExtension},
                {"imageFolder", ImageFolder},
                {"isPreinstalled", IsPreinstalled},
                {"isRatingEnabled", IsRatingEnabled},
                {"locale", Locale},
                {"packageFileExtension", PackageFileExtension},
                {"packageFileName", PackageFileName},
                {"inAppPurchaseID", InAppPurchaseID},
                {"subtitle", Subtitle},
                {"uuid", Uuid}
            };
        }

        private void UpdateFiles()
        {
            Plist.WriteXml(MetadataToDictionary(), Path.Combine(_tempPack.FullName, "Settings.plist"));
            Plist.WriteXml(new Dictionary<string, object> { { "gameCards",
                                                                   CasesToArray().
                                                                   Select(arrElem => arrElem.ToDictionary(i => i.Key, i => ((object)i.Value))).ToList<Dictionary<string,object>>() } },
                Path.Combine(_tempPack.FullName, "CardGame.plist"));
        }

        public string Export(string folder)
        {
            UpdateFiles();

            var path = Path.Combine(folder, PackageFileName + "." + PackageFileExtension);
            if (Directory.Exists(path))
            {
                switch (MessageBox.Show(strings.packageOverride,
                    strings.packageExists, MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Helper.DeleteAllFilesAndSubfolders(new DirectoryInfo(path));
                        break;
                    case DialogResult.No:
                        Uuid = Guid.NewGuid().ToString().ToUpper();
                        UpdateFiles();
                        path = Path.Combine(folder, PackageFileName + "." + PackageFileExtension);
                        break;
                    case DialogResult.Cancel:
                        return null;
                }

            }
            Helper.CopyAllFiles(_tempPack.FullName, path);

            return path;
        }

        public Case CreateAndAddNewCase()
        {
            var imageFolder = Directory.CreateDirectory(Path.Combine(_tempPack.FullName, ImageFolder));
            Case newCase = new Case(imageFolder, ImageFileExtension);
            AddCase(newCase);

            return newCase;
        }

        public void Dispose()
        {
            var folder = new DirectoryInfo(_tempSessionPath);
            if (folder.Exists)
            {
                Helper.DeleteAllFilesAndSubfolders(folder);
                folder.Delete();
            }
        }

        public Set()
        {
            Uuid = Guid.NewGuid().ToString().ToUpper();
            _tempPack = Directory.CreateDirectory(Path.Combine(_tempSessionPath, PackageFileName + "." + PackageFileExtension));
            Directory.CreateDirectory(Path.Combine(_tempPack.FullName , ImageFolder));
        }

        private Set(Dictionary<string, object> casesData, Dictionary<string, object> metadata, string sourceFolder)
        {
            DetailDescription = metadata["detailDescription"].ToString();
            EditionName = metadata["editionName"].ToString();
            Locale = metadata["locale"].ToString();
            Subtitle = metadata["subtitle"].ToString();
            Uuid = metadata["uuid"].ToString().ToUpper();

            var path = _tempSessionPath + PackageFileName + "." + PackageFileExtension + "\\";

            if (!Directory.Exists(path))
            {
                _tempPack = Directory.CreateDirectory(path);
            }
            else
            {
                _tempPack = new DirectoryInfo(path);
                Helper.DeleteAllFilesAndSubfolders(_tempPack);
            }
            var imageFolder = Directory.CreateDirectory(Path.Combine(_tempPack.FullName, ImageFolder));

            Dictionary<string, string>[] cases = ((List<object>)casesData.Values.First()).Select(i => ((Dictionary<string, object>)i).ToDictionary(k => k.Key, k => k.Value.ToString())).ToArray();

            foreach (var d in cases)
            {
                var c = new Case(d, imageFolder, ImageFileExtension);
                _cases.Add(new Guid(c.Uuid), c);
            }



            Helper.CopyAllFiles(Path.Combine(sourceFolder, ImageFolder), imageFolder.FullName);
            FileInfo cover =
                    new FileInfo(Path.Combine(sourceFolder, CoverFileName + "." + CoverFileExtension));
            if (cover.Exists)
            {
                File.Copy(cover.FullName, Path.Combine(_tempPack.FullName, CoverFileName + "." + CoverFileExtension));
            }
        }

        public Set(string folder)
            : this(
                Plist.ReadPlist<Dictionary<string, object>>(folder + "\\CardGame.plist")
           ,
            Plist.ReadPlist<Dictionary<string, object>>(folder + "\\Settings.plist"), folder)
        {


        }

        ~Set()
        {
            Dispose();
        }
    }
}
