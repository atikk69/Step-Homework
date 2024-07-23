import React from 'react';

export default function BlogPosts({ posts }) {
    return (
        <div className="relative flex max-w-[24rem] flex-col rounded-xl bg-white bg-clip-border text-gray-700 shadow-md">
            <div className="relative m-0 overflow-hidden rounded-none bg-transparent bg-clip-border text-gray-700 shadow-none">
                <img
                    src="https://images.unsplash.com/photo-1522202176988-66273c2fd55f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1471&q=80"
                    alt="ui/ux review check"
                />
            </div>
            <div className="p-6">
                <h4 className="block font-sans text-2xl font-semibold leading-snug tracking-normal text-blue-gray-900 antialiased">
                    UI/UX Review Check
                </h4>
                <p className="mt-3 block font-sans text-xl font-normal leading-relaxed text-gray-700 antialiased">
                    Because it's about motivating the doers. Because I'm here to follow my
                    dreams and inspire others.
                </p>
            </div>
            <div className="flex items-center justify-between p-6">
                <div className="flex items-center space-x-3">
                    <img
                        alt="natali craig"
                        src="https://images.unsplash.com/photo-1580489944761-15a19d654956?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1061&q=80"
                        className="relative inline-block h-9 w-9 rounded-full border-2 border-white object-cover object-center hover:z-10"
                        data-tooltip-target="author-1"
                    />
                    <img
                        alt="tania andrew"
                        src="https://images.unsplash.com/photo-1633332755192-727a05c4013d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1480&q=80"
                        className="relative inline-block h-9 w-9 rounded-full border-2 border-white object-cover object-center hover:z-10"
                        data-tooltip-target="author-2"
                    />
                </div>
                <p className="block font-sans text-base font-normal leading-relaxed text-inherit antialiased">
                    January 10
                </p>
            </div>

            <div className="w-full pt-5 px-4 mb-8 mx-auto">
                <div className="text-sm text-gray-700 py-1">
                    Made with{' '}
                    <a
                        className="text-gray-700 font-semibold"
                        href="https://www.material-tailwind.com/docs/html/card?ref=tailwindcomponents"
                        target="_blank"
                        rel="noopener noreferrer"
                    >
                        Material Tailwind
                    </a>{' '}
                    by{' '}
                    <a
                        href="https://www.creative-tim.com?ref=tailwindcomponents"
                        className="text-gray-700 font-semibold"
                        target="_blank"
                        rel="noopener noreferrer"
                    >
                        Creative Tim
                    </a>
                    .
                </div>
            </div>

            <link
                rel="stylesheet"
                href="https://unpkg.com/@material-tailwind/html@latest/styles/material-tailwind.css"
            />
        </div>
    );
}