﻿
namespace SilverlightWCF_RIA.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies studentMetadata as the class
    // that carries additional metadata for the student class.
    [MetadataTypeAttribute(typeof(student.studentMetadata))]
    public partial class student
    {

        // This class allows you to attach custom attributes to properties
        // of the student class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class studentMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private studentMetadata()
            {
            }

            public string dianhua { get; set; }

            public int id { get; set; }

            public string jiguan { get; set; }

            public Nullable<double> kaofen { get; set; }

            public string xingbie { get; set; }

            public string xingming { get; set; }

            public byte[] zhaopian { get; set; }

            public string zhuanye { get; set; }
        }
    }
}
