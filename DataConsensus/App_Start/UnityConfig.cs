using System.Web.Http;
using BAL.BusinessLogic;
using DAL.InterfaceRepository;
using DAL.Repositories;
using DAL.UnitOfWork;
using Shared_Layer.Interface;
using Unity;
using Unity.Injection;
using Unity.WebApi;

namespace DataConsensus
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            // for repos to Unit of Work
            container.RegisterType<IUnitofWork, UoWHouse>();
            container.RegisterType<HouseRepository>(new InjectionConstructor(container.Resolve<IUnitofWork>()));

            container.RegisterType<IUnitofWork, UoWMember>();
            container.RegisterType<MemberRepository>(new InjectionConstructor(container.Resolve<IUnitofWork>()));

            container.RegisterType<IUnitofWork, UoWPopulation>();
            container.RegisterType<PopulationRepository>(new InjectionConstructor(container.Resolve<IUnitofWork>()));

            container.RegisterType<IUnitofWork, UoWUser>();
            container.RegisterType<UserRepository>(new InjectionConstructor(container.Resolve<IUnitofWork>()));




            //for BAL to Repos

            container.RegisterType<IMemberRepos, MemberRepository>();
            container.RegisterType<IUserRepos, UserRepository>();
            container.RegisterType<BusinessLogicMember>(new InjectionConstructor(container.Resolve<IMemberRepos>(), container.Resolve<IUserRepos>()));

            container.RegisterType<IUserRepos, UserRepository>();
            container.RegisterType<BusinessLogicUser>(new InjectionConstructor(container.Resolve<IUserRepos>()));

            container.RegisterType<IPopulationRepos, PopulationRepository>();
            container.RegisterType<IHouseRepos, HouseRepository>();
            container.RegisterType<BusinessLogicHouse>(new InjectionConstructor(container.Resolve<IHouseRepos>()));

            container.RegisterType<IPopulationRepos, PopulationRepository>();
            container.RegisterType<BusinessLogicPopulation>(new InjectionConstructor(container.Resolve<IPopulationRepos>()));


            //for BAL
            container.RegisterType<IBusinessMember, BusinessLogicMember>();
            container.RegisterType<IBusinessUser, BusinessLogicUser>();
            container.RegisterType<IBusinessHouse, BusinessLogicHouse>();
            container.RegisterType<IBusinessPopulation, BusinessLogicPopulation>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}