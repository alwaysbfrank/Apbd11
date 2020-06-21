using System;
using Apbd11.Dtos;
using Apbd11.Models;
using Apbd11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apbd11
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {

        private readonly DoctorService _doctors;

        public DoctorController(DoctorService doctors)
        {
            _doctors = doctors;
        }

        [HttpGet]
        //[Route("/")]
        public IActionResult GetAll()
        {
            var allDoctors = _doctors.GetAllDoctors();
            Console.WriteLine("returning " + allDoctors.Count + " doctors");
            return Ok(allDoctors);
        }

        [HttpPut]
        [Route("/{id}/")]
        public IActionResult UpdateDoctor(int id, DoctorRequest request)
        {
            return Return(_doctors.UpdateDoctor(id, request));
        }

        private IActionResult Return(bool result)
        {
            return Return(result, NoContent());
        }
        
        private IActionResult Return(bool result, IActionResult okResult)
        {
            return result ? okResult : BadRequest();
        }

        [HttpDelete]
        [Route("/{id}/")]
        public IActionResult Delete(int id)
        {
            return Return(_doctors.RemoveDoctor(id));
        }

        [HttpPost]
        public IActionResult Create(DoctorRequest request)
        {
            return Return(_doctors.AddDoctor(request), Created("/api/doctors/", null));
        }
    }
}