//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EN_project.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubjectLecture
    {
        public int Id { get; set; }
        public Nullable<int> subject_id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    
        public virtual subject subject { get; set; }
    }
}
