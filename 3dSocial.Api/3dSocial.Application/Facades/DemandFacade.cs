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
                    ZipCode = dto.CenterZipCode
                };
                
                centerFacade.Insert(center);

                dto.CenterId = center.Id;
            }

            //if(center.Id == 0)
            //    centerFacade.Insert(center);
            //else
            //    centerFacade.Update(center);

            Demand demand = new Demand() { 
                CenterID = dto.CenterId,
                Observations = dto.Observations,
                ProjectID = dto.ProjectId,
                TotalDelivered = dto.TotalDelivered,
                TotalNeed = dto.TotalNeed
            };

            service.Post<DemandValidator>(demand);

            dto.DemandId = demand.Id;
        }

        public void Delete(int _Id)
        {
            service.Delete(new Demand { Id = _Id });
        }
    }
}
