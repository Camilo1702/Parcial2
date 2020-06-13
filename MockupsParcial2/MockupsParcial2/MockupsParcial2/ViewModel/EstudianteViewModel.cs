using System;
using System.Collections.Generic;
using System.Text;

namespace MockupsParcial2.ViewModel
{
    public class EstudianteViewModel:BaseViewModel
    {
        //apiservices
        #region Attributes
        private string albumid;
        private string id;
        private string title;
        private string url;
        private string thumbnailurl;

        #endregion

        #region Properties
        public string AlbumId
        {
            get { return this.albumid; }
            set { SetValue(ref this.albumid, value); }
        }
        public string Id
        {
            get { return this.id; }
            set { SetValue(ref this.id, value); }
        }
        public string Title
        {
            get { return this.title; }
            set { SetValue(ref this.title, value); }
        }
        public string Url
        {
            get { return this.url; }
            set { SetValue(ref this.url, value); }
        }
        public string ThumbnailUrl
        {
            get { return this.thumbnailurl; }
            set { SetValue(ref this.thumbnailurl, value); }
        }

        #endregion
    }
}
