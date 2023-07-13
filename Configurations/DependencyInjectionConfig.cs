using Web_Api_CRUD.Repository.Interfaces.Livraria;
using Web_Api_CRUD.Repository.Interfaces.Usuarios;
using Web_Api_CRUD.Repository.Livraria;
using Web_Api_CRUD.Repository.Usuarios;


namespace Web_Api_CRUD.Configurations
{
    public static class DependencyInjectionConfig
    {
            public static IServiceCollection ResolveDependencies (
                this IServiceCollection services
            )

            {
                services.AddScoped<ILivroRepository, LivroRepository>();
                services.AddScoped<ILocalizacaoRepository, LocalizacaoRepository>();
                services.AddScoped<IUsuarioRepository, UsuarioRepository>();

                return services;
            }
        
    }
}