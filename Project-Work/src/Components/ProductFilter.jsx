// src/components/ProductFilter.jsx
import React, { useState } from 'react';

const PriceRanges = [
  { label: 'All', value: '' },
  { label: 'Under $30', value: '30' },
  { label: '$30 to $60', value: '60' },
  { label: 'Over $60', value: '61' }
];

const ProductFilter = ({ onFilterChange }) => {
  const [priceRange, setPriceRange] = useState('');

  const handlePriceChange = (event) => {
    const value = event.target.value;
    setPriceRange(value);
    onFilterChange(value);
  };

  return (
    <div className="p-4">
      <h2 className="text-xl font-bold mb-2">Filter by Price</h2>
      <select
        value={priceRange}
        onChange={handlePriceChange}
        className="border border-gray-300 rounded p-2"
      >
        {PriceRanges.map((range) => (
          <option key={range.value} value={range.value}>
            {range.label}
          </option>
        ))}
      </select>
    </div>
  );
};

export default ProductFilter;
