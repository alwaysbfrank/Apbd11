using System.Collections.Generic;
using System.Linq;
using Apbd11.Daos;
using Apbd11.Dtos;
using Apbd11.Models;

namespace Apbd11.Services
{
    public class DoctorService
    {
        private readonly MedicineDbContext _db;

        public DoctorService(MedicineDbContext db)
        {
            _db = db;
        }

        public List<Doctor> GetAllDoctors()
        {
            return _db.Doctors.ToList();
        }

        public bool UpdateDoctor (int id, DoctorRequest updateRequest)
        {
            var updated = new Doctor()
            {
                Id = id,
                Email = updateRequest.Email,
                FirstName = updateRequest.FirstName,
                LastName = updateRequest.LastName
            };
            _db.Doctors.Attach(updated);

            if (updateRequest.Email != null)
            {
                _db.Entry(updated).Property("Email").IsModified = true;
            }

            if (updateRequest.FirstName != null)
            {
                _db.Entry(updated).Property("FirstName").IsModified = true;
            }

            if (updateRequest.LastName != null)
            {
                _db.Entry(updated).Property("LastName").IsModified = true;
            }

            return _db.SaveChanges() == 1;
        }

        public bool RemoveDoctor(int id)
        {
            _db.Doctors.Remove(new Doctor {Id = id});

            return _db.SaveChanges() == 1;
        }

        public bool AddDoctor(DoctorRequest newDoctor)
        {
            _db.Add(new Doctor
            {
                Email = newDoctor.Email,
                LastName = newDoctor.LastName,
                FirstName = newDoctor.FirstName
            });
            return _db.SaveChanges() == 1;
        }
    }
}