import React, { useState } from 'react';
import { useDispatch } from 'react-redux';
import { addToCart } from '../Store/cartSlice';
import ProductFilter from '../Components/ProductFilter';

const products = [
  { id: 1, name: 'T-Shirt', price: 25.00, image: 'https://isto.pt/cdn/shop/files/Heavyweight_Black_ef459afb-ff7a-4f9a-b278-9e9621335444.webp?v=1710414950', description: 'A basic T-Shirt.' },
  { id: 2, name: 'Jeans', price: 50.00, image: 'https://static.e-stradivarius.net/5/photos4/2024/V/0/1/p/7343/202/702/7343202702_2_4_1.jpg?t=1689848347406&impolicy=stradivarius-itxmediumhigh&imwidth=480&imformat=chrome&imdensity=2.625', description: 'Comfortable jeans.' },
  { id: 3, name: 'Jacket', price: 75.00, image: 'https://cdn.shopify.com/s/files/1/0123/5065/2473/files/BM17064.473BLK_BLACK-STORM-STOPPER-BOMBER-JACKET.jpg?v=1696607398', description: 'A stylish jacket.' },
  { id: 4, name: 'Shoes', price: 100.00, image: 'https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/377758/01/sv01/fnd/IDN/fmt/png/ForeverRun-NITRO%E2%84%A2-Women', description: 'Running shoes.' },
  { id: 5, name: 'Hoodie', price: 20.00, image: 'https://www.davidgandywellwear.com/cdn/shop/products/Ultimate-Loopback-Hoodie-Black.jpg?v=1677258480', description: 'Warm hoodie.' },
  { id: 6, name: 'Dress', price: 130.00, image: 'https://m.media-amazon.com/images/I/61z18CoyHBL._AC_UY1000_.jpg', description: 'Elegant dress.' },
  { id: 7, name: 'Skirt', price: 40.00, image: 'https://www.slaters-schoolwear.co.uk/wp-content/uploads/2020/06/Millbrook-38Slaters_SchoolWear-edit.jpg', description: 'Chic skirt.' },
  { id: 8, name: 'Blouse', price: 35.00, image: 'https://www.ionlinekl.com.my/cdn/shop/products/cicada-ladies-wear-two-way-loose-fit-blouse-blue--2.jpg?v=1716190114', description: 'Stylish blouse.' },
  { id: 9, name: 'Shorts', price: 25.00, image: 'https://m.media-amazon.com/images/I/51AWKhIKDSL._AC_UY1000_.jpg', description: 'Comfortable shorts.' },
  { id: 10, name: 'Coat', price: 150.00, image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeDY9X5MiaTTdgP3KGcXNjnoveH4IbqGuSRw&s', description: 'Warm coat.' },
  { id: 11, name: 'Sneakers', price: 90.00, image: 'https://m.media-amazon.com/images/I/51rnEOfH6hL._AC_UY900_.jpg', description: 'Trendy sneakers.' },
  { id: 12, name: 'Sweater', price: 45.00, image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNZA7BJtzTNqSxSd3U4bu91QolesAEuOGYjg&s', description: 'Cozy sweater.' },
  { id: 13, name: 'Cap', price: 15.00, image: 'https://m.media-amazon.com/images/I/71XnZ+esX+L._AC_UY1000_.jpg', description: 'Fashionable cap.' },
  { id: 14, name: 'Scarf', price: 20.00, image: 'https://www.simone-et-georges.com/images/produits-simone-et-georges/foulard-philippine-805/foulard-philippine-805-3_600.jpg', description: 'Soft scarf.' },
  { id: 15, name: 'Belt', price: 30.00, image: 'https://m.media-amazon.com/images/I/71nur0EMx9L._UF1000,1000_QL80_.jpg', description: 'Leather belt.' }
];

const CatalogItems = () => {
  const dispatch = useDispatch();
  const [filteredProducts, setFilteredProducts] = useState(products);

  const handleAddToCart = (product) => {
    dispatch(addToCart(product));
  };

  const handleFilterChange = (priceRange) => {
    let filtered = products;
    if (priceRange === '30') {
      filtered = products.filter(product => product.price < 30);
    } else if (priceRange === '60') {
      filtered = products.filter(product => product.price >= 30 && product.price <= 60);
    } else if (priceRange === '61') {
      filtered = products.filter(product => product.price > 60);
    }
    setFilteredProducts(filtered);
  };

  return (
    <div className="bg-indigo-50">
      <ProductFilter onFilterChange={handleFilterChange} />
      <section className="min-h-screen body-font text-gray-600">
        <div className="container mx-auto px-5 py-10 flex">
          <div className="flex-1">
            <div className="-m-4 flex flex-wrap">
              {filteredProducts.map((product) => (
                <div key={product.id} className="w-full p-4 md:w-1/2 lg:w-1/4">
                  <a className="relative block h-48 overflow-hidden rounded">
                    <img
                      alt={product.name}
                      className="block h-full w-full object-cover object-center cursor-pointer"
                      src={product.image}
                    />
                  </a>
                  <div className="mt-4">
                    <h3 className="title-font mb-1 text-xs tracking-widest text-gray-500">PRODUCT</h3>
                    <h2 className="title-font text-lg font-medium text-gray-900">{product.name}</h2>
                    <p className="mt-1">${product.price.toFixed(2)}</p>
                    <p className="mt-1 text-gray-500">{product.description}</p>
                    <button
                      onClick={() => handleAddToCart(product)}
                      className="mt-4 bg-blue-500 text-white py-2 px-4 rounded"
                    >
                      Add to Cart
                    </button>
                  </div>
                </div>
              ))}
            </div>
          </div>
        </div>
      </section>
    </div>
  );
};

export default CatalogItems;
