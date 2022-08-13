using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorDesignPattern.Models
{
    public class FinancialSystem
    {
        private readonly IList<IElement> _elementsList;

        public FinancialSystem()
        {
            _elementsList = new List<IElement>();
        }

        public void Attach(IElement element)
        {
            _elementsList.Add(element);
        }

        public void Detach(IElement element)
        {
            _elementsList.Remove(element);
        }

        public List<int> Accept(IElementVisitor visitor)
        {
            List<int> list1 = new List<int>();
            foreach (var element in _elementsList)
            {
                list1.Add( element.Accept(visitor));
            }
            return list1;
        }
    }
}