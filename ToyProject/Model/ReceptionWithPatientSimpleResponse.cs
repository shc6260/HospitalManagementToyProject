using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class ReceptionWithPatientSimpleResponse
    {
        public ReceptionWithPatientSimpleResponse(long id, DateTime reception_dt, string patientName, string chartnumber)
        {
            Id = id;
            Reception_dt = reception_dt;
            PatientName = patientName;
            Chartnumber = chartnumber;
        }


        public long Id { get; }

        public DateTime Reception_dt { get; }

        public string PatientName { get; }

        public string Chartnumber { get; }


        public static ReceptionWithPatientSimpleResponse From(ReceptionWithPatientSimpleResponseDto dto)
        {
            return new ReceptionWithPatientSimpleResponse
            (
                id: dto.Id,
                reception_dt: dto.Reception_dt,
                patientName: dto.PatientName,
                chartnumber: dto.Chartnumber
            );
        }
    }
}
