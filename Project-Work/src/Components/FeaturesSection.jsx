// src/components/FeaturesSection.jsx
import React from 'react';

const features = [
  {
    title: "Simplicity in Design",
    description: "No flashy logos. No senseless details. Just the world's most comfortable shoes and clothing, made naturally and designed practically. It's that simple.",
    imageUrl: "https://thrivethinking.com/wp-content/uploads/2019/10/BehaviorChange1.jpg" 
  },
  {
    title: "Confidence in Comfort",
    description: "Trying is believing. Give our products a shot for 30 days, and if you're not completely satisfied, we'll take them back - no questions asked.",
    imageUrl: "https://st.depositphotos.com/1086305/1223/i/450/depositphotos_12233696-stock-photo-small-kitty.jpg" 
  },
  {
    title: "Made from Nature",
    description: "The fashion industry often overlooks Mother Nature's materials in favor of cheaper, synthetic alternatives. We think it's time to change that.",
    imageUrl: "https://arc.losrios.edu/arc/main/img/ARC03-Academics/instruction/ARC-Science-and-Engineering-Division/ARC-Natural-Resources/ARC-natural-resources-940x529.jpg" 
  }
];

const FeaturesSection = () => {
  return (
    <section className="bg-gray-100 py-12">
      <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div className="text-center mb-12">
          <h2 className="text-4xl font-extrabold text-gray-900 sm:text-5xl">
            Our Key Features
          </h2>
        </div>
        <div className="grid grid-cols-1 gap-8 sm:grid-cols-2 lg:grid-cols-3">
          {features.map((feature, index) => (
            <div key={index} className="bg-white rounded-lg shadow-lg overflow-hidden">
              <img className="w-full h-48 object-cover" src={feature.imageUrl} alt={feature.title} />
              <div className="p-6">
                <h3 className="text-2xl font-semibold text-gray-900">{feature.title}</h3>
                <p className="mt-4 text-gray-600">{feature.description}</p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
}

export default FeaturesSection;
