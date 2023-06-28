using UnityEngine;
using Plex.

namespace UniPlex.Core.Control
{
    public class PlexController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Create Client Options
            var apiOptions = new ClientOptions
            {
                Product = "API_UnitTests",
                DeviceName = "API_UnitTests",
                ClientId = "MyClientId",
                Platform = "Web",
                Version = "v1"
            };

            // Setup Dependency Injection
            var services = new ServiceCollection();
            services.AddSingleton(apiOptions);
            services.AddTransient<IPlexServerClient, PlexServerClient>();
            services.AddTransient<IPlexAccountClient, PlexAccountClient>();
            services.AddTransient<IPlexLibraryClient, PlexLibraryClient>();
            services.AddTransient<IApiService, ApiService>();
            services.AddTransient<IPlexFactory, PlexFactory>();
            services.AddTransient<IPlexRequestsHttpClient, PlexRequestsHttpClient>();
    
            this.ServiceProvider = services.BuildServiceProvider();
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
