using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorDesignPattern.Models
{
    public interface IElement
    {
        int WorkingHour { get; set; }
        int Wife { get; set; }
        int Children { get; set; }
        int OffDays { get; set; }
        int OverHours { get; set; }
        int Accept(IElementVisitor visitor);
    }

    public interface IElementVisitor
    {
        int Visit(Manager manager);
        int Visit(Employee manager);
        int Visit(Worker manager);
    }

    
}