using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetColor(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
