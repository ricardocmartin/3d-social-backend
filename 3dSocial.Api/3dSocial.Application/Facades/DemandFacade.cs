using _3dSocial.Application.DTO;
using _3dSocial.Application.Interfaces;
using _3dSocial.Domain.Entities;
using _3dSocial.Service.Services;
using _3dSocial.Service.Validators;
using System.Collections.Generic;

namespace _3dSocial.Application.Facades
{
    public class DemandFacade : IDemandFacade
    {
        private BaseService<Demand> service = new BaseService<Demand>();
        private CenterFacade centerFacade = new CenterFacade();
        private EmailService emailService = new EmailService();

        public Demand Get(int Id)
        {
            return service.Get(Id);
        }

        public IList<Demand> List()
        {
            return service.Get();
        }

        public void Update(Demand obj)
        {
            service.Put<DemandValidator>(obj);
        }

        public void Insert(Demand obj)
        {
            service.Post<DemandValidator>(obj);
        }

        public void Insert(DemandDTO dto)
        {
            if (dto.CenterId == 0) { 
                Center center = new Center() {
                    AddressNumber = dto.CenterAddressNumber,
                    City = dto.CenterCity,
                    District = dto.CenterDistrict,
                    Document = dto.CenterDocument,
                    Id = dto.CenterId,
                    Name = dto.CenterName,
                    Street = dto.CenterStreet,
                    ZipCode = dto.CenterZipCode,
                    State = dto.State,
                    Phone = dto.Phone,
                    Ddd = dto.Ddd,
                    Email = dto.Email,
                    AllowShowInfo = dto.AllowShowInfo
                };
                
                centerFacade.Insert(center);

                dto.CenterId = center.Id;
            }

            Demand demand = new Demand() {
                CenterID = dto.CenterId,
                Observations = dto.Observations,
                ProjectID = dto.ProjectId,
                Active = true, //TODO: deixar inativo
                TotalDelivered = dto.TotalDelivered,
                TotalNeed = dto.TotalNeed
            };

            service.Post<DemandValidator>(demand);

            emailService.CreteEmailMsg(
                "Nova demanda cadastrada"
                , $"Atenção, uma nova demanda foi cadastrada\n\nCentro: {dto.CenterName};\nId do Projeto: {dto.ProjectId}; "
                , true
                , EmailsToSend());

            dto.DemandId = demand.Id;
        }

        private List<List<string>> EmailsToSend() {

            List<string> dest = new List<string>();
            dest.Add("ricardo.cmartin@gmail.com");
            dest.Add("Ricardo Castro Martin");

            List<List<string>> dests = new List<List<string>>();
            dests.Add(dest);

            return dests;
        }

        public void Delete(int _Id)
        {
            service.Delete(new Demand { Id = _Id });
        }
    }
}
