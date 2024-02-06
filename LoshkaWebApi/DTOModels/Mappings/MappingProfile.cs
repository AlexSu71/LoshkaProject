using AutoMapper;
using LoshkaLibrary.Models;
using LoshkaWebApi.DTOModels.DTO;

namespace LoshkaWebApi.DTOModels.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Ingredient, IngredientDto>();
            CreateMap<IngredientDto, Ingredient>();

            CreateMap<NutritionalValue, NutritionalValueDto>();
            CreateMap<NutritionalValueDto, NutritionalValue>();

            CreateMap<Recipe, RecipeDto>();
            CreateMap<RecipeDto, Recipe>();

            CreateMap<RecipeCategory, RecipeCategoryDto>();
            CreateMap<RecipeCategoryDto, RecipeCategory>();

            CreateMap<RecipeIngredient, RecipeIngredientDto>();
            CreateMap<RecipeIngredientDto, RecipeIngredient>();

            CreateMap<Unit, UnitDto>();
            CreateMap<UnitDto, Unit>();
        }
    }
}
