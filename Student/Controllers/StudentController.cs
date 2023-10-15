using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Student.Controllers
{
    
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("student/getstudent")]
        [HttpGet]
        public IEnumerable<StudentModel> getAllStudent() {
            List<StudentModel> studentModels = new List<StudentModel>();

            StudentModel student1 = new StudentModel();
            student1.Name = "Damith";
            student1.Gurdian = "Saman";
            student1.AdmissionDate = DateTime.Now;
            student1.ClassId = 1;

            StudentModel student2 = new StudentModel();
            student2.Name = "Vihari";
            student2.Gurdian = "Nimali";
            student2.AdmissionDate = DateTime.Now;
            student2.ClassId = 2;

            studentModels.Add(student1);
            studentModels.Add(student2);

            return studentModels;
        }

        [HttpGet]
        [Route("student/getClass")]
        public IActionResult getClassFromStudent() {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44343/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("class/allclass").Result;

            if (response.IsSuccessStatusCode)
            {
                List<ClassRoomModel> o = JsonConvert.DeserializeObject<List<ClassRoomModel>>(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine(o[0]);
                Console.WriteLine(o[0].classId);
                return Ok(response.Content.ReadAsStringAsync().Result);
            }
            else {
                return BadRequest("Some thing went wrong");
            }



        }

    }
}
