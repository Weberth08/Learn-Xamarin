using System;

namespace MonkeyApp.Models
{
    public class BaseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
