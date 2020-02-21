using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hieraechy02
{
    class Photo : Content
    {
        public Photo(string Name, DateTime UploadDate)
            :base(Name, UploadDate)
        {
            this.Name = Name;
            this.UploadDate = UploadDate;


        }
        public List<string> WhoIsOnPicture;

        public void SetWhoIsOnPicture(string[] WhoIsOnPicture)
        {
            this.WhoIsOnPicture.AddRange(WhoIsOnPicture);  
        }

        public override string ToString()
        {
            string resString = "На фото ";
            foreach (var item in WhoIsOnPicture)
                resString += $" {item} ";

            return resString;
        }

    }
}
