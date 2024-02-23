﻿namespace Epreuve_ASP_MVC.Handlers
{
    public static class FormFileHandler
    {
        public static async Task SaveFile(this IFormFile file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/assets/img/", file.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
    }
}
