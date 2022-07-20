export class soccerPlayer{
    itemId: number;
    name: string;
    description: string;
    price: number;
    stock: number;

    // need to add users
  
    constructor(itemId: number, name: string, description: string, price: number, stock:number,) {
      this.itemId = itemId;
      this.name = name;
      this.description = description;
      this.price = price;
      this.stock = stock;
    }
}