// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MenuItemExample
    /// </summary>
    public partial class MenuItemExample
    {
        /// <summary>
        /// Initializes a new instance of the MenuItemExample class.
        /// </summary>
        public MenuItemExample() { }

        /// <summary>
        /// Initializes a new instance of the MenuItemExample class.
        /// </summary>
        public MenuItemExample(string name1 = default(string), MenuItemExampleItem menuItemExampleItem = default(MenuItemExampleItem))
        {
            Name1 = name1;
            MenuItemExampleItem = menuItemExampleItem;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name1")]
        public string Name1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MenuItemExampleItem")]
        public MenuItemExampleItem MenuItemExampleItem { get; set; }

    }
}
