//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepartmentEmployeesTerminal.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassDocument
    {
        public int Id { get; set; }
        public string DocumentFile { get; set; }
        public Nullable<int> PassId { get; set; }
    
        public virtual Pass Pass { get; set; }
    }
}
