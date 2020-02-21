using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hieraechy02
{
    abstract class Content
    {
        public int ID;
        
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }

        public Content(string Name, DateTime UploadDate) 
        {
            this.Name = Name;
            this.UploadDate = UploadDate;
        }
        

        public override string ToString()
        {
            string resString = $" Название содержания - {Name} дата загрузга - {UploadDate}";
            return resString;
        }
    }
}
