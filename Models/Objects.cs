using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BuildersExchangeProject.Models
{
    public class Objects
    {
        public class ASSIGNEDCAT
        {
            [ForeignKey("CAT_ID")]
            public int Cat_ID { get; set; }
            [ForeignKey("USER_ID")]
            public LINK URL_ID { get; set; }
        }
        public class ASSIGNEDUSER
        {
            [Key]
            public int URL_ID { get; set; }
            
            public ApplicationUser USER_ID { get; set; }
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
            [ForeignKey("Filter_ID")]
            public FILTER FILTER_ID { get; set; }
        }
        public class LINKDATA
        {
            [Key]
            public int STATIC_LINK_ID { get; set; }
            public string LinkMD5 { get; set; }
            [ForeignKey("URL_ID")]
           public LINK URL_ID { get; set; }
        }
        
    }
}