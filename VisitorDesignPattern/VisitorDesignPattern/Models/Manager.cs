using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorDesignPattern.Models
{
    public class  Manager: IElement
    {
        public int WorkingHour { get; set; } = 8;
        public int Wife { get; set; } = 1;
        public int Children { get; set; } = 3;
        public int OffDays { get; set; } = 6;
        public int OverHours { get; set; } = 12;

        public int Accept(IElementVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}