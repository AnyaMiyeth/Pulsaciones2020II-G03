using System;
using System.Collections.Generic;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public decimal CalcularPulsacion (string sexo, int edad)
        {
            decimal pulsacion = 0;
            if (sexo.ToUpper().Equals("F"))
            {
                pulsacion = (220 - edad) / 10;
            }
            else if (sexo.ToUpper().Equals("M"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = 0;
            }

            return pulsacion;
        }


        public string Guardar(Persona persona)
        {
            try
            {
                personaRepository.Guardar(persona);
                return "Se guardó la Informarción satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error de Aplicacion:" + e.Message;
            }
        }
    }
}
