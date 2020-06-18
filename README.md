# NetcoreRazorPageToPdf
free dotnet core 3.1 razor page to PDF example, based on open-source and free 

* wkhtmltopdf [https://github.com/wkhtmltopdf/wkhtmltopdf]

wrapped for dotnet core with 

* rotativa [https://www.nuget.org/packages/Rotativa.AspNetCore/1.2.0-beta#]

based upon custom class to support Razor Page instead of mvc view from

* https://stackoverflow.com/questions/59349176/razor-pages-pdf-generation-with-rotativa-model-null/59352364#59352364

## Limited support for html5 flex-box and flex-grid
I believe wkhtmltopdf project has lack of support of these css concepts, per 15. june 2020.
https://github.com/wkhtmltopdf/wkhtmltopdf/issues/4678

However, table is supported.
