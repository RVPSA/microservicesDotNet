using ClassManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagement.Controllers
{
    
    [ApiController]
    public class ClassController : ControllerBase
    {
        
        [HttpGet]
        [Route("class/allclass")]
        public IEnumerable<ClassRoomModel> getAllClassRoom() {
            List<ClassRoomModel> classRoomModels = new List<ClassRoomModel>();

            ClassRoomModel classRoom1 = new ClassRoomModel();
            classRoom1.classId = 1;
            classRoom1.className = "M1";

            ClassRoomModel classRoom2 = new ClassRoomModel();
            classRoom2.classId = 2;
            classRoom2.className = "M2";

            classRoomModels.Add(classRoom1);
            classRoomModels.Add(classRoom2);

            return classRoomModels;

        }
    }
}
