using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Mapper.Initialize(cfg =>
             {
                 cfg.CreateMap<Employee, EmployeeDTO>()
                 .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                 .ForMember(dest => dest.Inner, act => act.MapFrom(src => src.Inner))
                 .ForAllOtherMembers(x => x.Ignore());
                 cfg.CreateMap<InnerSource, InnerDest>()
                 .ForMember(dest => dest.OtherValue, act => act.MapFrom(src => src.OtherValue))
                 .ForAllOtherMembers(x => x.Ignore());
             });

             Employee emp = new Employee();
             emp.Name = "James";
             emp.Salary = 20000;
             emp.Address = "London";
             emp.Department = "IT";
             emp.Inner = new InnerSource() { OtherValue = 2 };
             //Step3: use the mapper to map the source and destination object
             var empDTO = Mapper.Map<Employee, EmployeeDTO>(emp);
             Console.WriteLine(empDTO.FullName); */
             
            //mapping of destination children property to source property
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ItemInventoryDomainModel, CsvItemProductDomainModel>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.BundledItemFlag, act => act.MapFrom(src => src.BundledItemFlag))
                .ForMember(dest => dest.CategoryName, act => act.MapFrom(src => src.ItemCategoryName))
                .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.ItemId ))
                .ForMember(dest => dest.CsvBundledItemDetails, act => act.MapFrom(src => src.BundledItemDetails))
                .AfterMap((source, destination) =>
                {
                     foreach(var destinationchild in destination.CsvBundledItemDetails)
                    {
                        destinationchild.ItemId = source.ItemId;
                    }
                })
                .ForAllOtherMembers(x => x.Ignore());


                cfg.CreateMap<BundledItemsInventoryDomainModel, CsvItemBundledItemDomainModel>()
                .ForMember(dest => dest.SkuId, act => act.MapFrom(src => src.SkuId))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.CompositionNumber, act => act.MapFrom(src => src.CompositionNumber))
                .ForAllOtherMembers(x => x.Ignore());
            });

            ItemInventoryDomainModel emp = new ItemInventoryDomainModel();
            emp.Name = "James";
            emp.BundledItemFlag = true;
            emp.ItemId = "2";
            emp.ItemCategoryName = "IT";
            emp.BundledItemDetails = new List<BundledItemsInventoryDomainModel>()
            {
                new BundledItemsInventoryDomainModel()
                {
                    SkuId="abc",
                    Name="childitem",
                    CompositionNumber = 5
                }
            };
            //Step3: use the mapper to map the source and destination object
            var empDTO = Mapper.Map<ItemInventoryDomainModel, CsvItemProductDomainModel>(emp);
            Console.WriteLine(empDTO.Name);

            Console.ReadLine();

        }

    }
}
