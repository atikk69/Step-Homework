// src/components/Home.jsx
import React from 'react';

const Home = () => {
  return (
    <div>
      <div className="w-screen h-screen overflow-hidden relative before:block before:absolute before:bg-black before:h-full before:w-full before:top-0 before:left-0 before:z-10 before:opacity-30">
        <img src="https://www.thefashionisto.com/wp-content/uploads/2023/06/Asian-Male-Models.jpg" className="absolute top-0 left-0 min-h-full w-full object-cover" alt="Background" />
        <div className="relative z-20 max-w-screen-lg mx-auto grid grid-cols-12 h-full items-center">
          <div className="col-span-6">
            <span className="uppercase text-white text-xs font-bold mb-2 block">WE ARE FASHION EXPERTS</span>
            <h1 className="text-white font-extrabold text-5xl mb-8">Elevate Your Style with Our Exclusive Collections</h1>
            <p className="text-stone-100 text-base">
              Discover the latest trends and timeless classics, tailored to your style. Upgrade your wardrobe with our carefully curated pieces.
            </p>
            <button className="mt-8 text-white uppercase py-4 text-base font-light px-10 border border-white hover:bg-white hover:bg-opacity-10">Shop Now</button>
          </div>
        </div>
      </div>
      <div className="bg-[#f7d0b6] py-20">
        <div className="max-w-screen-lg mx-auto flex justify-between items-center">
          <div className="max-w-xl">
            <h2 className="font-black text-sky-950 text-3xl mb-4">Leading Fashion Trends Across 90+ Countries</h2>
            <p className="text-base text-sky-950">Stay ahead of the curve with our global fashion insights. From streetwear to high fashion, we have something for every style.</p>
          </div>
          <button className="text-sky-950 uppercase py-3 text-base px-10 border border-sky-950 hover:bg-sky-950 hover:bg-opacity-10">Learn More</button>
        </div>
      </div>
      <div className="py-12 relative overflow-hidden bg-white">
        <div className="grid grid-cols-2 max-w-screen-lg mx-auto">
          <div className="w-full flex flex-col items-end pr-16">
            <h2 className="text-[#64618C] font-bold text-2xl max-w-xs text-right mb-12 mt-10">Personalized Styling Just for You</h2>
            <div className="h-full mt-auto overflow-hidden relative">
              <img src="https://images.bauerhosting.com/empire/2023/10/statham-ayer-stallone.jpg?ar=16%3A9&fit=crop&crop=top&auto=format&w=1440&q=80" className="h-full w-full object-contain" alt="Styling Advice" />
            </div>
          </div>
          <div className="py-20 bg-slate-100 relative before:absolute before:h-full before:w-screen before:bg-sky-950 before:top-0 before:left-0">
            <div className="relative z-20 pl-12">
              <h2 className="text-[#f7d0b6] font-black text-5xl leading-snug mb-10">Expert Fashion Guidance</h2>
              <p className="text-white text-sm">
                Get tips from our fashion experts to ensure you always look your best. Our personalized advice will help you find the perfect outfit for any occasion.
              </p>
              <button className="mt-8 text-white uppercase py-3 text-sm px-10 border border-white hover:bg-white hover:bg-opacity-10">Talk with an Expert</button>
            </div>
          </div>
        </div>
      </div>
      <div className="py-4 relative overflow-hidden bg-white">
        <div className="grid grid-cols-2 max-w-screen-lg mx-auto">
          <div className="py-20 bg-slate-100 relative before:absolute before:h-full before:w-screen before:bg-[#f7d0b6] before:top-0 before:right-0">
            <div className="relative z-20 pl-12">
              <h2 className="text-sky-950 font-black text-5xl leading-snug mb-10">Embrace the Latest Fashion</h2>
              <p className="text-sky-950 text-sm">
                Our collections feature the latest styles and trends, designed to keep you looking chic and fashionable.
              </p>
              <button className="mt-8 text-sky-950 uppercase py-3 text-sm px-10 border border-sky-950 hover:bg-white hover:bg-opacity-10">Explore Collections</button>
            </div>
          </div>
          <div className="w-full flex flex-col pl-16">
            <h2 className="text-[#64618C] font-bold text-2xl max-w-xs text-left mb-12 mt-10">Personal Styling Sessions</h2>
            <div className="h-full mt-auto overflow-hidden relative">
              <img src="https://img.freepik.com/premium-photo/model-podium-fashion-week_829699-608.jpg" className="h-full w-full object-contain" alt="Styling Advice" />
            </div>
          </div>
        </div>
      </div>
      <div className="py-12 relative overflow-hidden bg-white">
        <div className="grid grid-cols-2 max-w-screen-lg mx-auto">
          <div className="w-full flex flex-col items-end pr-16">
            <h2 className="text-[#64618C] font-bold text-2xl max-w-xs text-right mb-12 mt-10">Elevate Your Wardrobe</h2>
            <div className="h-full mt-auto overflow-hidden relative">
              <img src="https://s0.rbk.ru/v6_top_pics/media/img/4/37/346952046784374.webp" className="h-full w-full object-contain" alt="Styling Advice" />
            </div>
          </div>
          <div className="py-20 bg-slate-100 relative before:absolute before:h-full before:w-screen before:bg-sky-950 before:top-0 before:left-0">
            <div className="relative z-20 pl-12">
              <h2 className="text-[#f7d0b6] font-black text-5xl leading-snug mb-10">Fashion Tailored to You</h2>
              <p className="text-white text-sm">
                Discover outfits tailored to your personal style. Our curated collections ensure you always have the perfect look.
              </p>
              <button className="mt-8 text-white uppercase py-3 text-sm px-10 border border-white hover:bg-white hover:bg-opacity-10">Find Your Style</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Home;
