using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NodejsWebApp2.Models
{

    public class Make
    {

        public int Id { get; set; }

        public String nome { get; set; }

        public ICollection<Model> Models { get; set; }

        public Make()
        {
            Models = new Collection<Model>();
        }
    }


}
