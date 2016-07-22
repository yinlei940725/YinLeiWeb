using Common.Model;
using Common.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DAL
{
    public class TestDB
    {
        public void CreateDataBase()
        {
            DBEntity db = new DBEntity();
            db.Resume.FirstOrDefault();
        }

        public void Insert(Resume model)
        {
            DBEntity db = new DBEntity();
            db.Set<Resume>().Add(model);
            db.SaveChanges();
        }

        public Resume GetResume(int id)
        {
            Resume info = new Resume();
            DBEntity db = new DBEntity();
            info = db.Resume.Where(w => w.Id == id).FirstOrDefault();
            return info;
        }
    }
}
