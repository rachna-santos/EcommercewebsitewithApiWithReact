using EcommercewebsitewithApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
using NuGet.Versioning;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace EcommercewebsitewithApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
        //[Authorize]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly IConfiguration _configuration;

        public ProductController(MyDbContext context, IWebHostEnvironment hostEnvironment, IConfiguration configuration)
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
            _configuration = configuration;
        }

        [Authorize]

        [HttpGet("ProductGet")]
        public IActionResult Get()
        {
            var product = _context.product.ToList();
            return Ok(product);
        }
        [HttpPost("ProductCreate")]
        public async Task<IActionResult> Create([FromForm] Product model)
        {
            model.Createdate = DateTime.Now;
            model.lastdate = DateTime.Now;
            _context.product.Add(model);
            await _context.SaveChangesAsync();
            var file = model.image;
            var uniqueFileName = $"{model.ProductId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductLogo");
            var filename = "Image/ProductLogo/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.product.Update(model);
            _context.SaveChanges();
            return Ok(fullImagePath);
        }
        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = _context.product.FirstOrDefault(x => x.ProductId == id);
            return Ok(product);
        }

        [HttpPut("ProductEdit")]
        public async Task<IActionResult> Edit(int id, [FromForm] Product model)
        {
            var product = _context.product.Find(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.Name = model.Name;
            product.quantity = model.quantity;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Title = model.Title;
            product.CategoryId = model.CategoryId;
            product.subCategoryId = model.subCategoryId;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.ProductId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductLogo");
            var filename = "Image/ProductLogo/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deleteproduct")]
        public async Task<IActionResult> ProductDelete(int id)
        {
            var Product = await _context.product.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductLogo", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.product.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("CategoryGet")]

        public async Task<IActionResult> GetCat()
        {
            var cat = _context.category.ToList();
            return Ok(cat);
        }

        [HttpPost("CategoryCreate")]
        public async Task<IActionResult> CategoryCreate([FromForm] Category model)
        {
            model.Createdate = DateTime.Now;
            model.lastdate = DateTime.Now;
            _context.category.Add(model);
            await _context.SaveChangesAsync();
            var file = model.image;
            var uniqueFileName = $"{model.CategoryId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Category");
            var filename = "Image/Category/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.category.Update(model);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("CategoryEditId")]
        public async Task<IActionResult> CategoryEdit(int id)
        {
            var product = _context.category.FirstOrDefault(x => x.CategoryId == id);
            return Ok(product);
        }
        [HttpPut("CategoryEdit")]
        public async Task<IActionResult> CategoryEdit(int id, [FromForm] Category model)
        {
            var product = _context.category.Find(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Title = model.Title;
            product.subCategoryId = model.subCategoryId;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.CategoryId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Category");
            var filename = "Image/Category/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            //_context.category.Update(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deleteCategory")]
        public async Task<IActionResult> CategoryDelete(int id)
        {
            var Product = await _context.category.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/Category", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.category.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("SubCategoryCreate")]
        public async Task<IActionResult> SubCategoryCreate([FromForm] SubCategory model)
        {
            model.Createdate = DateTime.Now;
            model.lastdate = DateTime.Now;
            _context.subCategories.Add(model);
            await _context.SaveChangesAsync();
            var file = model.image;
            var uniqueFileName = $"{model.subCategoryId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/SubCategory");
            var filename = "Image/SubCategory/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.subCategories.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("SubCategoryEdit")]
        public async Task<IActionResult> SubCategoryEdit(int id)
        {
            var product = _context.subCategories.FirstOrDefault(x => x.subCategoryId == id);
            return Ok(product);
        }
        [HttpPut("SubCategoryEdit")]
        public async Task<IActionResult> SubCategoryEdit(int id, [FromForm] SubCategory model)
        {
            var product = await _context.subCategories.FindAsync(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Title = model.Title;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.subCategoryId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/SubCategory");
            var filename = "Image/SubCategory/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            //_context.category.Update(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deletesubcategory")]
        public async Task<IActionResult> SubcategoryDelete(int id)
        {
            var Product = await _context.subCategories.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/SubCategory", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.subCategories.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("Brand")]
        public async Task<IActionResult> GetBrand()
        {
            var brand = _context.brands.ToList();
            return Ok(brand);
        }
        [HttpPost("BrandCreate")]
        public async Task<IActionResult> Create([FromForm] Brand model)
        {
            model.lastdate = DateTime.Now;
            model.Createdate = DateTime.Now;
            _context.brands.Add(model);
            _context.SaveChanges();
            var file = model.image;
            var uniqueFileName = $"{model.BrandId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Brand");
            var filename = "Image/Brand" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.brands.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("BrandEditId")]
        public async Task<IActionResult> BrandEdit(int id)
        {
            var product = _context.brands.FirstOrDefault(x => x.BrandId == id);
            return Ok(product);
        }
        [HttpPut("BrandEdit")]
        public async Task<IActionResult> BrandEdit(int id, [FromForm] Brand model)
        {
            var product = await _context.brands.FindAsync(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.BrandName = model.BrandName;
            product.BrandDescription = model.BrandDescription;
            product.BrandPhone = model.BrandPhone;
            product.Title = model.Title;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.BrandId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Brand");
            var filename = "Image/Brand/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            //_context.category.Update(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deleteBrand")]
        public async Task<IActionResult> brandDelete(int id)
        {
            var Product = await _context.brands.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/brand", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.brands.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("MaterialGet")]
        public async Task<IActionResult> GetMaterial()
        {
            var brand = _context.brands.ToList();
            return Ok(brand);
        }
        [HttpPost("MaterialCreate")]
        public async Task<IActionResult> Create([FromForm] Material model)
        {
            model.lastdate = DateTime.Now;
            model.Createdate = DateTime.Now;
            _context.materials.Add(model);
            _context.SaveChanges();
            var file = model.image;
            var uniqueFileName = $"{model.MaterialId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Material");
            var filename = "Image/Material" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.materials.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("MaterialEditId")]
        public async Task<IActionResult> MaterialEdit(int id)
        {
            var product = _context.materials.FirstOrDefault(x => x.MaterialId == id);
            return Ok(product);
        }
        [HttpPut("MaterialEdit")]
        public async Task<IActionResult> MaterialEdit(int id, [FromForm] Material model)
        {
            var product = await _context.materials.FindAsync(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.Title = model.Title;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.MaterialId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Material");
            var filename = "Image/Material/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            //_context.category.Update(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deleteMaterial")]
        public async Task<IActionResult> MaterialDelete(int id)
        {
            var Product = await _context.materials.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/Material", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.materials.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("genderCreate")]
        public async Task<IActionResult> Create([FromForm] Gender model)
        {
            model.lastdate = DateTime.Now;
            model.Createdate = DateTime.Now;
            _context.genders.Add(model);
            _context.SaveChanges();
            var file = model.image;
            var uniqueFileName = $"{model.genderId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Gender");
            var filename = "Image/Gender" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.ImagePath = filename;
            _context.genders.Update(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("GenderEditId")]
        public async Task<IActionResult> GenderEdit(int id)
        {
            var product = _context.genders.FirstOrDefault(x => x.genderId == id);
            return Ok(product);
        }
        [HttpPut("GenderEdit")]
        public async Task<IActionResult> GenderEdit(int id, [FromForm] Gender model)
        {
            var product = await _context.genders.FindAsync(id);
            if (product == null)
            {
                return BadRequest(product);
            }
            product.Title = model.Title;
            product.StatusId = model.StatusId;
            product.Createdate = DateTime.Now;
            product.lastdate = DateTime.Now;
            var file = model.image;
            var uniqueFileName = $"{product.genderId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Gender");
            var filename = "Image/Gender/" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            product.ImagePath = filename;
            //_context.category.Update(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("deleteGender")]
        public async Task<IActionResult> GenderDelete(int id)
        {
            var Product = await _context.genders.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/Gender", Product.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.genders.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("sizeCreate")]
        //public async Task<IActionResult> Create([FromBody] Size model)
        //{
        //    model.lastdate = DateTime.Now;
        //    model.Createdate = DateTime.Now;
        //    _context.sizes.Add(model);
        //    _context.SaveChanges();
        //    return Ok(model);
        //}
        //[HttpGet("SizeEditId")]
        //public async Task<IActionResult> SizeEdit(int id)
        //{
        //    var product = _context.sizes.FirstOrDefault(x => x.SizeId == id);
        //    return Ok(product);
        //}
        //[HttpPut("sizeEdit")]
        //public async Task<IActionResult> SizeEdit(int id, [FromForm] Size model)
        //{
        //    var product = await _context.sizes.FindAsync(id);
        //    if (product == null)
        //    {
        //        return BadRequest();
        //    }
        //    product.SizeName = model.SizeName;
        //    product.lastdate = DateTime.Now;
        //    product.Createdate = DateTime.Now;
        //    product.StatusId = model.StatusId;
        //    _context.sizes.Update(product);
        //    _context.SaveChanges();
        //    return Ok(model);
        //}
        //[HttpDelete("sizeDelete")]
        //public async Task<IActionResult> SizeDelete(int id)
        //{
        //    var product = _context.sizes.Find(id);
        //    _context.sizes.Remove(product);
        //    _context.SaveChanges();
        //    return Ok();
        //}

        //[HttpPost("ColorCreate")]
        //public async Task<IActionResult> ColorCreate([FromForm] Color model)
        //{
        //    model.lastdate = DateTime.Now;
        //    model.Createdate = DateTime.Now;
        //    _context.colors.Add(model);
        //    _context.SaveChanges();
        //    var file = model.image;
        //    var uniqueFileName = $"{model.ColorId}.jpg";
        //    var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Color");
        //    var filename = "Image/Color" + uniqueFileName;
        //    var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
        //    if (!Directory.Exists(imageDirectory))
        //    {
        //        Directory.CreateDirectory(imageDirectory);
        //    }
        //    using (var stream = new FileStream(fullImagePath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }
        //    model.ImagePath = filename;
        //    _context.colors.Update(model);
        //    _context.SaveChanges();
        //    return Ok(model);
        //}
        //[HttpGet("ColorEditId")]
        //public async Task<IActionResult> EditId(int id)
        //{
        //    var product = _context.colors.FirstOrDefault(x => x.ColorId == id);
        //    return Ok(product);
        //}

        //[HttpPut("ColorEdit")]
        //public async Task<IActionResult> ColorEdit(int id, [FromForm] Color model)
        //{
        //    var product = await _context.colors.FindAsync(id);
        //    if (product == null)
        //    {
        //        return BadRequest(product);
        //    }
        //    product.colorName = model.colorName;
        //    product.colorcode1 = model.colorcode1;
        //    product.colorcode2 = model.colorcode2;
        //    product.StatusId = model.StatusId;
        //    product.Createdate = DateTime.Now;
        //    product.lastdate = DateTime.Now;
        //    var file = model.image;
        //    var uniqueFileName = $"{product.ColorId}.jpg";
        //    var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/Color");
        //    var filename = "Image/Color/" + uniqueFileName;
        //    var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
        //    if (!Directory.Exists(imageDirectory))
        //    {
        //        Directory.CreateDirectory(imageDirectory);
        //    }
        //    using (var stream = new FileStream(fullImagePath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }
        //    product.ImagePath = filename;
        //    //_context.category.Update(product);
        //    _context.Entry(product).State = EntityState.Modified;
        //    _context.SaveChanges();
        //    return Ok(product);
        //}
        //[HttpDelete("deleteColor")]
        public async Task<IActionResult> ColorDelete(int id)
        {
            var data = _context.colors.Find(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, data.ImagePath);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _context.colors.Remove(data);
            _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("DeleteCountry")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _context.countries.FindAsync(id);
            _context.countries.Remove(country);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("CreateCountry")]
        public async Task<IActionResult> Create([FromBody] Country model)
        {
            var country = new Country();
            {
                country.countryName = model.countryName;
                await _context.countries.AddAsync(model);
                _context.SaveChanges();
            };

            return Ok();
        }

        [HttpGet("editid")]
        public async Task<IActionResult> GetId(int id)
        {
            var city = await _context.countries.Where(p => p.countryId == id).FirstOrDefaultAsync();
            return Ok(city);
        }
        [HttpPut("Editcountry")]
        public async Task<IActionResult> Edit([FromBody] Country model, int id)
        {

            var country = await _context.countries.FindAsync(id);
            country.countryName = model.countryName;
            _context.countries.Update(country);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet("Getcity")]
        public async Task<IActionResult> getcity()
        {
            var city = await _context.cities.ToListAsync();
            return Ok(city);
        }

        [HttpPost("CityCreate")]
        public async Task<IActionResult> CityCreate([FromBody] City model)
        {
            model.cityName = model.cityName;
            model.cityName = model.cityName;
            _context.cities.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }

        [HttpGet("Editcityid")]
        public async Task<IActionResult> Editid(int id)
        {
            var city = await _context.cities.Where(p => p.cityId == id).FirstOrDefaultAsync();
            return Ok(city);
        }
        [HttpPut("Editcity")]
        public async Task<IActionResult> Edit([FromBody] City model, int id)
        {
            var city = await _context.cities.FindAsync(id);
            if (city == null)
            {
                return BadRequest(city);
            }
            city.cityName = model.cityName;
            city.countryId = model.countryId;
            _context.cities.Update(city);
            _context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("Deletecity")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.cities.FindAsync(id);
            _context.cities.Remove(city);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("GetProductseason")]
        public async Task<IActionResult> GetIndex()
        {
            var season = _context.productSeasons.ToList();
            return Ok(season);
        }

        [HttpPost("createSeasonProdcut")]
        public async Task<IActionResult> Create([FromForm] ProductSeason model)
        {
            model.CreateDate = DateTime.Now;
            model.Lastmodifield = DateTime.Now;
            _context.productSeasons.Add(model);
            _context.SaveChanges();
            var file = model.image;
            var uniqueFileName = $"{model.productseasonId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductSeason");
            var filename = "Image/ProductSeason" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            model.imagepath = filename;
            _context.productSeasons.Update(model);
            _context.SaveChanges();
            return Ok(model);

        }
        [HttpGet("Editseasonid")]
        public async Task<IActionResult> GetEdit(int id)
        {
            var season = _context.productSeasons.Where(p => p.productseasonId == id).FirstOrDefault();
            return Ok(season);
        }
        [HttpPut("Editseason")]
        public async Task<IActionResult> Edit([FromForm] ProductSeason model, int id)
        {
            var season = _context.productSeasons.Where(p => p.productseasonId == id).FirstOrDefault();
            season.productseasonName = model.productseasonName;
            season.description = model.description;
            season.title = model.title;
            season.Keyword = model.Keyword;
            model.CreateDate = DateTime.Now;
            model.Lastmodifield = DateTime.Now;
            model.StatusId = model.StatusId;
            var file = model.image;
            var uniqueFileName = $"{model.productseasonId}.jpg";
            var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductSeason");
            var filename = "Image/ProductSeason" + uniqueFileName;
            var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            using (var stream = new FileStream(fullImagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            season.imagepath = filename;
            _context.Entry(season).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(model);

        }

        [HttpDelete("Deleteseason")]
        public async Task<IActionResult> SeasonDelete(int id)
        {
            var season = await _context.productSeasons.FindAsync(id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductSeason", season.imagepath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.productSeasons.Remove(season);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("ImageAdd")]
        public async Task<IActionResult> CreateImage([FromForm] ProductImage model)
        {
            for (int i = 0; i < model.profilepicture.Count; i++)
            {
                var files = model.profilepicture[i];
                if (files.Length > 0)
                {
                    var uniqueFileName = $"{model.productId}_{i + 1}_{Guid.NewGuid().ToString()}.jpg";
                    var imageDirectory = Path.Combine(hostEnvironment.WebRootPath, "Image/ProductImage");
                    var filename = "Image/ProductImage/" + uniqueFileName;
                    var fullImagePath = Path.Combine(imageDirectory, uniqueFileName);
                    if (!Directory.Exists(imageDirectory))
                    {
                        Directory.CreateDirectory(imageDirectory);
                    }

                    using (var stream = new FileStream(fullImagePath, FileMode.Create))
                    {
                        await files.CopyToAsync(stream);
                    }

                    var newImage = new ProductImage
                    {
                        CreateDate = DateTime.Now,
                        Lastmodifield = DateTime.Now,
                        StatusId = 5,
                        productId = model.productId,
                        iamgepath = filename,
                        imagepath_thumb = filename
                    };

                    _context.productImages.Add(newImage);
                    await _context.SaveChangesAsync();
                }
            }
            return Ok();
        }
        [HttpPost("createcountryUser")]
        public IActionResult Create([FromBody] userCountry country)
        {
            country.CountryName = country.CountryName;
            country.Createdate = DateTime.Now;
            country.lastdate = DateTime.Now;
            _context.userCountries.Add(country);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("createcityUser")]
        public IActionResult Create([FromBody] UserCity city)
        {

            city.CityName = city.CityName;
            city.Createdate = DateTime.Now;
            city.lastdate = DateTime.Now;
            _context.userCities.Add(city);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("usercityGet")]
        public IActionResult citylist()
        {
            var city = _context.userCities.ToList();
            return Ok(city);
        }

        [HttpGet("userCountryGet")]
        public IActionResult countrylist()
        {
            var country = _context.userCountries.ToList();
            return Ok(country);
        }
        [HttpPost("createcustomer")]
        public IActionResult Create([FromForm] Customer customer)
        {
            customer.Name = customer.Name;
            customer.Email = customer.Email;
            customer.Password = customer.Password;
            customer.Address = customer.Address;
            customer.Telephone = customer.Telephone;
            customer.CountryId = customer.CountryId;
            customer.CityId = customer.CityId;
            _context.customers.Add(customer);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("LoginCustomer")]
        public IActionResult Login([FromBody] customerlogin customer)
        {
            var cust = _context.customers.FirstOrDefault(p => p.Email == customer.Email && p.Password == customer.Password);
            if (cust != null)
            {
                Response.Cookies.Append("Custid", cust.Id.ToString(), new CookieOptions
                {
                    Expires = DateTime.UtcNow.AddMonths(1)
                }); 

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
               issuer: _configuration["JWT:ValidIssuer"],
               audience: _configuration["JWT:ValidAudience"],
               expires: DateTime.Now.AddHours(3),
               signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)

               );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });

            }
            return Unauthorized();
        }

        [HttpPost("CreateVeriation")]
        public IActionResult AddVeriation([FromForm] Productveriation model)
        {
            var productId = model.productId;
            var image = _context.productImages.Where(p => p.productId == model.productId).Select(p => p.iamgepath).ToList();
            foreach (var item in image)
            {
                var veriation = new Productveriation
                {
                    BrandId = model.BrandId,
                    veriationName = model.veriationName,
                    productId = model.productId,
                    categoryId = model.categoryId,
                    costprice = model.costprice,
                    RetailerPrice = model.RetailerPrice,
                    ColoId = model.ColoId,
                    StatusId = 5,
                    Quantity = model.Quantity,
                    CreateDate = DateTime.Now,
                    Lastmodifield = DateTime.Now,
                };
                  veriation.image = item.ToString();
                _context.productveriations.Add(veriation);
                _context.SaveChanges();
            }
     
             return Ok();

        }

        [HttpGet("GetVeriation")]
        public IActionResult getVeraition(int productId) 
        {
            var productveraition = _context.productveriations.Where(p => p.productId == productId).ToList();
            return Ok(productveraition); 
        }
        [HttpPost("Addtocard")]
        public IActionResult addtocard(int veriationid)
        {

            int? Custid =Request.Cookies["Custid"]!=null ? int.Parse(Request.Cookies["Custid"]) : (int?)null;

            Productveriation p = _context.productveriations.Include(p=>p.Product).Where(p => p.veriationId == veriationid).FirstOrDefault();

            Cart_item cart = new Cart_item();
            cart.veriationId = veriationid;
            cart.quantity =p.Quantity;
            cart.price = p.costprice;
            cart.ColorId = p.ColoId;
            cart.bill = p.Quantity * p.costprice;
            cart.image = p.image;
            cart.Id = Custid.Value;
            List<Cart_item> cartitem = HttpContext.Session.GetObject<List<Cart_item>>("Cart") ?? new List<Cart_item>();
            cartitem.Add(cart);
            HttpContext.Session.SetObject("Cart", cartitem);
            return Ok();

        }

    }
    
}




