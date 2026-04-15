using AutoMapper;
using backend.Core.Dtos.Candidate;
using backend.Core.Dtos.Company;
using backend.Core.Dtos.Job;
using backend.Core.Entities;

namespace backend.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile: Profile
    {
        public AutoMapperConfigProfile()
        {
            //Company
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<Company, CompanyGetDto>();
            //Job
            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobGetDto>();
            //Candidate
            CreateMap<CanditateCreateDto, Candidate>();
            CreateMap<Candidate, CanditateGetDto>();
        }
    }
}
