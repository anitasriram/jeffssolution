using Microsoft.EntityFrameworkCore;

namespace CoursesApi.Controllers;

public class CoursesController : ControllerBase
{

    private readonly CourseCatalog _catalog;

    public CoursesController(CourseCatalog catalog)
    {
        _catalog = catalog;
    }

    [HttpGet("/courses")]
   
    public async  Task<ActionResult> GetCoursesAsync(CancellationToken token)
    {
        CoursesResponseModel response = await _catalog.GetFullCatalogAsync(token);

        //var response = new CoursesResponseModel { NumberOfBackendCourses = 99, NumberOfFrontendCourses = 12 };
        return Ok(response);
    }
}
