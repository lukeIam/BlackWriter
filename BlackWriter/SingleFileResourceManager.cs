using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Resources;
#pragma warning disable 618


namespace BlackWriter
{
    //Based on http://stackoverflow.com/q/1952638
    internal class SingleFileResourceManager : ResourceManager
    {
        private readonly Type _contextTypeInfo;

        public SingleFileResourceManager(String name, Type t)
            : base(name, t.Assembly)
        {
            _contextTypeInfo = t;
        }

        protected override ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists,
            bool tryParents)
        {
            ResourceSet rs = (ResourceSet)this.ResourceSets[culture];
            if (rs == null)
            {
                Stream store = null;
                string resourceFileName = null;

                resourceFileName = GetResourceFileName(culture);

                store = this.MainAssembly.GetManifestResourceStream(
                    this._contextTypeInfo, resourceFileName);

                if (store == null && culture.Parent.Name != "")
                {
                    resourceFileName = GetResourceFileName(culture.Parent);

                    store = this.MainAssembly.GetManifestResourceStream(
                        this._contextTypeInfo, resourceFileName) ??
                            this.MainAssembly.GetManifestResourceStream(resourceFileName);
                }

                //If we found the appropriate resources in the local assembly
                if (store != null)
                {
                    rs = new ResourceSet(store);
                    //save for later.
                    AddResourceSet(this.ResourceSets, culture, ref rs);
                }
                else
                {
                    rs = base.InternalGetResourceSet(culture, createIfNotExists, tryParents);
                }
            }

            return rs;
        }

        //private method in framework, had to be re-specified here.
        private static void AddResourceSet(Hashtable localResourceSets,
            CultureInfo culture, ref ResourceSet rs)
        {
            lock (localResourceSets)
            {
                ResourceSet objA = (ResourceSet)localResourceSets[culture];
                if (objA != null)
                {
                    if (!object.Equals(objA, rs))
                    {
                        rs.Dispose();
                        rs = objA;
                    }
                }
                else
                {
                    localResourceSets.Add(culture, rs);
                }
            }
        }
    }
}
