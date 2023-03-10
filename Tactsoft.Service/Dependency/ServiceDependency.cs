using Tactsoft.Service.Services.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactsoft.Service.Services;
using System.Security.Cryptography.X509Certificates;

namespace Tactsoft.Service.Dependency
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IBloodGroupService, BloodGroupService>();
            services.AddScoped<IBranchInfoServices, BranchInfoService>();
            services.AddScoped<ICityService, Cityservice>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<ICompanyInfoServices, CompanyInfoService>(); 
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IGenderServices, GenderService>();
            services.AddScoped<IMaritialStatusService, MaritialStatusService>();
            services.AddScoped<IProjectService, ProjectServices>();
            services.AddScoped<IReligionService, ReligionService>();
            services.AddScoped<IZipCodeService, ZipCodeService>();
            services.AddScoped<IEducationGroupService, EducationGroupService>();
            services.AddScoped<IDegreeService, DegreeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IEducationService,EducationService>();
            services.AddScoped<IDegreeService, DegreeService>();
            services.AddScoped<IProjectService, ProjectServices>();
            services.AddScoped<IServiceInfoService, ServiceInfoService>();
            services.AddScoped<IRelationShipService, RelationShipService>();
            services.AddScoped<ITrainingServices, TrainingServices>();
            services.AddScoped<IFamilyMemberServices,FamilyMemberService>();
            services.AddScoped<IDesignationService,DesignationService>();
            services.AddScoped<IAttachmentTypeService,AttachmentTypeService>();
            services.AddScoped<IAttachmentService,AttachmentService>();
            services.AddScoped<IAllowanceSettingServices, AllowanceSettingServices>();
            services.AddScoped<ILeaveTypeServices, LeaveTypeServices>();
            services.AddScoped<IAwardServices, AwardServices>();
            services.AddScoped<IAttandanceService, AttandanceService>();
            services.AddScoped<IAwardTypeServices, AwardTypeServices>();
            services.AddScoped<ISalaryTypeService, SalaryTypeService>();
            services.AddScoped<ISalarySetupService, SalarySetupService>();
            services.AddScoped<IDeductionService, DeductionService>();
            services.AddScoped<IAllowensService, AllowensService>();
            services.AddScoped<IAllowensDetailsService, AllowensDetailsService>();
            services.AddScoped<ILeaveApplictionService, LeaveApplictionService>();
            services.AddScoped<IEmploymentHistoryService, EmploymentHistoryService>();
            services.AddScoped<IAdvanceTypeService, AdvanceTypeService>();
            services.AddScoped<INomineeService, NomineeService>();
            services.AddScoped<IReferenceService, ReferenceService>();
            services.AddScoped<IAdvanceService, AdvanceService>();




        }
    } 
}
