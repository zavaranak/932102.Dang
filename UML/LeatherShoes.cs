class Manuefacturer(){
    public string brand;
    public string location;
    private int finance;

    private Supplier S; 
    public  Product[] products;
    public  Source[] sources;

    public  int Demand(int codeSupply){};
    //Получить сырьё, снять деньги из капитала
    public void getSupply(){      
        foreach(Source source in sources){
            int demand = Demand(source.materialCode);
            S.deviverSuplies();
            finance -= S.bill;
        }
    }
    //Нахождение продукт, увеличить его количество в вкладе, и снять сырья для производства
    public void Produce(int productCode, int quantity){
        Product x = findProduct(productCode);                                   //Нахождение
        if (x == null) break;
        foreach(Material component in x.component){
            downSource(component.materialCode, component.quantity)              //снять сыре в запасе
        }
        x.quantity += quantity;                                                 //+количество продукта
    }

    public Product findProduct(int code){
        foreach(Product product in products){
            if (product.productCode == code) {return product;}
        }
        return null;
    }
    public Source findSource(int code){
        foreach(Source source in sources){
            if (source.materialCodeode == code) {return source;}
        }
        return null;
    }
    public void downSource(int code, int quantity){
        Source forX = findSource(code);
        forX.quantity -= quantity;
    }
}
class Product(){
    public int productCode;
    public string ProductName;
    public int quantity;
    public Source[] components;
    //установить цену продукта
    public int setPrice(int ManuefacturerCost){
        int price;
        foreach(Material component in components){
            price += component.cost;
        }
        return price + ManuefacturerCost;
    };

}

class Material(){
    public int materialCode;
    public string materialName;
    public int cost;
}

class Source:Material{
    int quantity;
}

class Supplier(){
    public int bill;
    public void deliverSupply(Source Supply, int demand){
        foreach(Source supply in supplies){
            supply.quantity = demand;
            bill += supply.cost * demand;
        }
    };
}


class Distributor(){
    public int finance;
    public Product[] productsDistributor;
    public float profit = 0.2;                              //20% наценки
    public Retail[] Retailers;
    public int distributorDemand(int codeProduct);
    public void getProduct(Manuefacturer M)
    {   
        int bill;
        foreach(Product product in M.products)
        {   
            int demand = distributorDemand(product.codeProduct);                //Снят продукты из Производителя
            product.quantity-=demand;
            foreach(Product productD in productsDistributor){
                if (productsDistributor.codeProduct==product.codeProduct){      //Увеличивать продукты у Распределителя
                    productD+=demand;
                }
            }
            bill+=product.cost*demand;
        }
        M.finance+=bill;                //Платить производителю за продукты
        finance -= bill;                
    }
    
    public void sellToRetail(int codeProduct, int quantity, int codeRetail){       
        Retail  x = findRetail(codeRetail);
        Product fromRetail = x.findProductR(codeProduct);
        fromRetail.quantity+=quantity;
        Product toRetail = findProductD(codeProduct);
        toRetail.quantity-=quantity;                                             //Снять продукты при продажа
        int bill = toRetail.cost*quantity + (toRetail.cost*quantity)*profit;     //Прибыль у Распределителя           
        finance += bill;                                                        
    }

    public Product findProductD(int code){
        foreach(Product productD in productsDistributor){
            if (productD.productCode == code) {return productD;}
        }
        return null;
    }
    public Retail findRetail(int code){
     foreach(Retail Retailer in Retailers){
            if (Retailer.codeRetail == code) {return Retailer;}
        }
        return null;
    }
}

class Retail(){
    public int codeRetail;
    public string addressRetail;
    public Product[] ProductInStock;
    public Product findProductR(int code){
        foreach(Product productR in ProductInStock){
            if(productR.codeProduct==code) {return ProductR;}
        }
        return null;
    }
}



