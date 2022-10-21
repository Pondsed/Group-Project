public class Restaurant{
    private string restaurantName;
    private FoodMenu foodmenu;
    public Restaurant(string restaurantName,FoodMenu foodmenu){
        this.restaurantName = restaurantName;
        this.foodmenu = foodmenu;
    }
    public string GetRestaurantName() {
        return this.restaurantName;
    }

    public FoodMenu GetFoodMenu() {
        return this.foodmenu;
    }

}   