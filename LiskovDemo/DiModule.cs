namespace LiskovDemo.LiskovDemo
{
    using global::LiskovDemo.LiskovDemo.Shims;
    using global::LiskovDemo.Services;

    public static class DiModule
    {
        public static IServiceCollection AddLiskovDemo(this IServiceCollection services)
        {
            services.AddSingleton<INewService, NewService>();
            //services.AddSingleton<ILegacyService, LegacyService>();
            services.AddSingleton<ILegacyService, LegacyServiceShim>();

            return services;
        }
    }
}
