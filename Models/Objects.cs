using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuildersExchangeProject.Models
{
    public class Objects
    {
        public class ASSIGNEDCAT
        {
            [Key]
            public int Cat_ID { get; set; }
            [Key]
            public int URL_ID { get; set; }
        }
        public class ASSIGNEDUSER
        {
            [Key]
            public int URL_ID { get; set; }
     
            [Key]
            public int CUSTOMER_ID { get; set; }
        }
        public class CATEGORIES
        {
            [Key]
            public int CAT_ID { get; set; }
            public string CAT_NAME { get; set; }

        }
        public class FILTER
        {
            [Key]
            public int FILTER_ID { get; set; }
            public string FILTER_NAME { get; set; }
            public int FILTER_OBJECT { get; set; }
        }
        public class LINK
        {
            [Key]
            public int URL_ID { get; set; }
            public string URL { get; set; }
            [Key]
            public int FILTER_ID { get; set; }
        }
        public class LINKDATA
        {
            [Key]
            public int STATIC_LINK_ID { get; set; }
            public string LinkMD5 { get; set; }
            [Key]
            public int URL_ID { get; set; }
        }
        
    }
}