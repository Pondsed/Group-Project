public class Inventory {
    private Menu[] menus;

    public Inventory(Menu[] menus) {
        this.menus = menus;
    }

    public Menu GetMenu(string foodName) {
        foreach(Menu menu in menus) {
            if (menu.GetFoodName().Equals(foodName)) {
                return menu;
            }
        }

      
    }
}