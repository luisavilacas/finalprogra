﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace operacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase

    {
        [HttpGet]
        public string operaciones (int numero)
        {
            string texto= " " ;
            if (numero==0)
            {
                texto = "Realizado por Luis  Avila Castillo";

            }
            if (numero <0)
            {
                texto = "ERROR";
            }
            if (numero>0 )
            {
                texto = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
            }
            return texto;
        }
        
    }
}
