using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hieraechy02
{
    class Video : Content
    {
        
        public int Length { get; set; }

        public Video(string Name, DateTime UploadDate, int Length)
            :base(Name,UploadDate)
        {
            this.Length = Length;
        }

        public override string ToString()
        {
            string resString = base.ToString() + $" длинна видео- {Length} ";
            return resString;
        }

    }
}
