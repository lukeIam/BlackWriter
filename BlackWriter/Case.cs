using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BlackWriter
{
    public class Case
    {
        private readonly DirectoryInfo _imageFolder;
        private readonly string _imageFileExtension;


        public string Answer { get; set; }
        public string AnswerImageFileName { get; private set; }
        public string Question { get; set; }
        public string QuestionImageFileName { get; set; }
        public string Title { get; set; }
        public string Uuid { get; private set; }


        public Image AnswerImage
        {
            get
            {
                FileInfo image =
                    new FileInfo(Path.Combine(_imageFolder.FullName, "answer_" + Uuid + "." + _imageFileExtension));
                if (!image.Exists)
                {
                    return null;
                }

                Image resultImg;
                using (Image img = Image.FromFile(image.FullName))
                {
                    resultImg = new Bitmap(img);
                }

                return resultImg;
            }

            set
            {
                FileInfo image =
                    new FileInfo(Path.Combine(_imageFolder.FullName, "answer_" + Uuid + "." + _imageFileExtension));
                if (image.Exists)
                {
                    image.Delete();
                }

                value.Save(image.FullName);
            }
        }

        public Image QuestionImage
        {
            get
            {
                FileInfo image =
                    new FileInfo(Path.Combine(_imageFolder.FullName, "question_" + Uuid + "." + _imageFileExtension));
                if (!image.Exists)
                {
                    return null;
                }

                Image resultImg;
                using (Image img = Image.FromFile(image.FullName))
                {
                    resultImg = new Bitmap(img);
                }

                return resultImg;
            }

            set
            {
                FileInfo image =
                    new FileInfo(Path.Combine(_imageFolder.FullName, "question_" + Uuid + "." + _imageFileExtension));
                if (image.Exists)
                {
                    image.Delete();
                }

                value.Save(image.FullName);
            }
        }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                {"answer", Answer},
                {"answerImageFileName", AnswerImageFileName},
                {"question", Question},
                {"questionImageFileName", QuestionImageFileName},
                {"title", Title},
                {"uuid", Uuid}
            };
        }

        public Case(DirectoryInfo imagePath, string imageFileExtension)
        {
            _imageFolder = imagePath;
            _imageFileExtension = imageFileExtension;
            Uuid = Guid.NewGuid().ToString().ToUpper();
            AnswerImageFileName = "answer_" + Uuid ;
            QuestionImageFileName = "question_" + Uuid;
            Answer = "";
            Question = "";
            Title = "Neuer Fall";
        }

        public Case(Dictionary<string, string> data, DirectoryInfo imagePath, string imageFileExtension)
        {
            _imageFolder = imagePath;
            _imageFileExtension = imageFileExtension;
            Answer = data["answer"];
            AnswerImageFileName = data["answerImageFileName"];
            Question = data["question"];
            QuestionImageFileName = data["questionImageFileName"];
            Title = data["title"];
            Uuid = data["uuid"];
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
