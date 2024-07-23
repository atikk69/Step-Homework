import React from 'react';

export default function CityInfo() {
    return (
        <div className="px-2 md:px-6 my-3 w-full text-black dark:text-white flex flex-col items-center">
            <div className="max-w-xl text-left flex flex-col w-full items-center justify-center md:p-4 md:border border-slate-300 dark:border-slate-600 rounded-xl">
                <div
                    className="w-full rounded-xl flex-col xl:flex-row bg-white dark:bg-slate-900 shadow-md"
                >
                    <div
                        className="rounded-t-xl w-full h-64 shadow-sm bg-cover"
                        style={{
                            backgroundImage: 'url("https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcRfbcyNrxN1EjDdp5hpinYhz4FfZnDxZTLqz9G75kdpYFZIZ9JGeXsmZbzOXlZ8APYRH3qZqiu7YCE7_3rPLEBmMKarR-YAg0nxogH_1g")'
                        }}
                    ></div>
        
                    <div className="w-full p-3 flex flex-col justify-between h-auto overflow-auto lg:h-auto">
                        <h1 className="text-left text-sm md:text-lg font-bold leading-normal">
                            Baku - The City of Winds
                        </h1>
                        <p className="text-sm">
                            Baku, the capital of Azerbaijan, is the largest city on the Caspian Sea and of the Caucasus region. 
                            Baku is known for its medieval walled old city, which contains the Palace of the Shirvanshahs, a vast royal complex, 
                            and the iconic stone Maiden Tower. Contemporary landmarks include the Zaha Hadid–designed Heydar Aliyev Center, 
                            and the Flame Towers, three pointed skyscrapers covered with LED screens.
                        </p>
        
                        <div className="flex mt-4">
                            <button
                                className="transition-all duration-100 text-center p-2 rounded-md text-white w-1/2 bg-gradient-to-r from-blue-700 to-blue-500 hover:shadow-md hover:from-blue-800 hover:to-blue-600"
                            >
                                View Full-Size
                            </button>
                            <div className="flex flex-col ml-4 w-1/2">
                                <h2 className="text-center text-xs mt-1 mb-2 text-blue-600 dark:text-blue-400 font-bold uppercase">
                                    Baku Article
                                </h2>
        
                                <span className="self-center text-xs text-blue-700 dark:text-blue-300 -mt-2">
                                    24/08/2022
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}