using OrchardCore.ResourceManagement;

namespace TheRonaldoTheme.OrchardCore
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("TheRonaldoTheme-vendor-jQuery")
                .SetUrl("~/TheRonaldoTheme/js/jquery-3.2.1.min.js", "~/TheRonaldoTheme/js/jquery.min.js")
                .SetCdn("https://code.jquery.com/jquery-3.2.1.min.js", "https://code.jquery.com/jquery-3.2.1.js")
                .SetCdnIntegrity("sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4=", "sha256-DZAnKJ/6XZ9si04Hgrsxu/8s717jcIzLy3oi35EouyE=")
                .SetVersion("3.2.1");

            manifest.DefineScript("TheRonaldoTheme-vendor-jQuery-migrate")
                .SetUrl("~/TheRonaldoTheme/js/jquery-migrate-3.0.1.min.js")
                .SetCdn("https://code.jquery.com/jquery-migrate-3.0.1.min.js", "https://code.jquery.com/jquery-migrate-3.0.1.js")
                .SetCdnIntegrity("sha256-F0O1TmEa4I8N24nY0bya59eP6svWcshqX1uzwaWC4F4=", "sha256-VvnF+Zgpd00LL73P2XULYXEn6ROvoFaa/vbfoiFlZZ4=")
                .SetVersion("3.0.1");

            manifest.DefineScript("TheRonaldoTheme-vendor-popper")
                .SetUrl("~/TheRonaldoTheme/js/popper.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js")
                .SetCdnIntegrity("sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1");

            manifest.DefineScript("TheRonaldoTheme-vendor-bootstrap")
                .SetUrl("~/TheRonaldoTheme/js/bootstrap.min.js")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js")
                .SetCdnIntegrity("sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM")
                .SetVersion("4.3.1");

            manifest.DefineScript("TheRonaldoTheme-vendor-jqueryeasing")
                .SetUrl("~/TheRonaldoTheme/js/jquery.easing.1.3.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js", "https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.js")
                .SetCdnIntegrity("sha512-ahmSZKApTDNd3gVuqL5TQ3MBTj8tL5p2tYV05Xxzcfu6/ecvt1A0j6tfudSGBVuteSoTRMqMljbfdU0g2eDNUA==", "sha512-brrjTp9G6MkKX5QjXwwAQkscfFpKi3okjyZ/M3vGwwg9qI1msoz7z+EbQBLXsTnVK3POjYBGHcQvX34GFKr/7A==")
                .SetVersion("1.3");

            manifest.DefineScript("TheRonaldoTheme-vendor-waypoints")
                .SetUrl("~/TheRonaldoTheme/js/jquery.waypoints.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/waypoints/4.0.0/jquery.waypoints.min.js", "https://cdnjs.cloudflare.com/ajax/libs/waypoints/4.0.0/jquery.waypoints.js")
                .SetCdnIntegrity("sha512-oy0NXKQt2trzxMo6JXDYvDcqNJRQPnL56ABDoPdC+vsIOJnU+OLuc3QP3TJAnsNKXUXVpit5xRYKTiij3ov9Qg==", "sha512-BnrjiUrz5UU3mBQD4awG5ekDBgTPUzpcNJtMQbNj4kfqStjn48180rUTEQjU5+Gf2BBfAtZETnMP4Khv0vcPug==")
                .SetVersion("4.0");

            manifest.DefineScript("TheRonaldoTheme-vendor-animateNumber")
                .SetUrl("~/TheRonaldoTheme/js/jquery.animateNumber.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jquery-animateNumber/0.0.14/jquery.animateNumber.min.js", "https://cdnjs.cloudflare.com/ajax/libs/jquery-animateNumber/0.0.14/jquery.animateNumber.js")
                .SetCdnIntegrity("sha512-WY7Piz2TwYjkLlgxw9DONwf5ixUOBnL3Go+FSdqRxhKlOqx9F+ee/JsablX84YBPLQzUPJsZvV88s8YOJ4S/UA==", "sha512-1QMfUOxKmBVh0AakHIAh5tQfEW2r0atqXu4lHbAxgKZZnMY06M5MuTUrB6F/nQ6vjImMrWirGcLM1W6yslREpg==");

            manifest.DefineScript("TheRonaldoTheme-vendor-magnificpopup")
                .SetUrl("~/TheRonaldoTheme/js/jquery.mangnific-popup.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js", "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.js")
                .SetCdnIntegrity("sha512-IsNh5E3eYy3tr/JiX2Yx4vsCujtkhwl7SLqgnwLNgf04Hrt9BT9SXlLlZlWx+OK4ndzAoALhsMNcCmkggjZB1w==", "sha512-C1zvdb9R55RAkl6xCLTPt+Wmcz6s+ccOvcr6G57lbm8M2fbgn2SUjUJbQ13fEyjuLViwe97uJvwa1EUf4F1Akw==")
                .SetVersion("1.1");

            manifest.DefineScript("TheRonaldoTheme-vendor-stellar")
                .SetUrl("~/TheRonaldoTheme/js/jquery.stellar.min.js");

            manifest.DefineScript("TheRonaldoTheme-vendor-carousel")
                .SetUrl("~/TheRonaldoTheme/js/owl.carousel.min.js");

            manifest.DefineScript("TheRonaldoTheme-vendor-scrollax")
                .SetUrl("~/TheRonaldoTheme/js/scrollax.min.js");

            manifest.DefineScript("TheRonaldoTheme-vendor-aos")
                .SetUrl("~/TheRonaldoTheme/js/aos.js");

            manifest.DefineScript("TheRonaldoTheme-vendor-main")
                .SetUrl("~/TheRonaldoTheme/js/main.js")
                .SetDependencies("TheRonaldoTheme-vendor-jQuery", "TheRonaldoTheme-vendor-jQuery-migrate",
                    "theronaldotheme-vendor-popper", "theronaldotheme-vendor-bootstrap", "theronaldotheme-vendor-jqueryeasing",
                    "theronaldotheme-vendor-waypoints", "theronaldotheme-vendor-animatenumber", "theronaldotheme-vendor-carousel",
                    "theronaldotheme-vendor-magnificpopup", "theronaldotheme-vendor-aos", "theronaldotheme-vendor-animatenumber",
                    "theronaldotheme-vendor-scrollax", "theronaldotheme-vendor-stellar"
           );

            manifest.DefineStyle("TheRonaldoTheme-vendor-openiconic")
                .SetUrl("~/TheRonaldoTheme/css/open-iconic-bootstrap.min.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/open-iconic/1.1.1/font/css/open-iconic.min.css")
                .SetCdnIntegrity("sha512-LeCmts7kEi09nKc+DwGJqDV+dNQi/W8/qb0oUSsBLzTYiBwxj0KBlAow2//jV7jwEHwSCPShRN2+IWwWcn1x7Q==");

            manifest.DefineStyle("TheRonaldoTheme-vendor-magnificpopup")
                .SetUrl("~/TheRonaldoTheme/css/magnific-popup.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css", "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.css")
                .SetCdnIntegrity("sha512-+EoPw+Fiwh6eSeRK7zwIKG2MA8i3rV/DGa3tdttQGgWyatG/SkncT53KHQaS5Jh9MNOT3dmFL0FjTY08And/Cw==", "sha512-WEQNv9d3+sqyHjrqUZobDhFARZDko2wpWdfcpv44lsypsSuMO0kHGd3MQ8rrsBn/Qa39VojphdU6CMkpJUmDVw==")
                .SetVersion("1.1");

        }
    }
}
