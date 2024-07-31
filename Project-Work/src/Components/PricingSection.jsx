
import React from 'react';

const plans = [
  {
    title: 'Базовый план',
    description: 'Идеально для индивидуальных пользователей и небольших команд.',
    price: '$49',
    features: [
      'Хорошее качество ткани',
      'Доступные цены',
      'Широкий выбор цветов'
    ],
    bgColor: 'bg-purple-100',
    textColor: 'text-purple-800',
    buttonColor: 'from-purple-600 to-indigo-600',
    buttonText: 'Начать'
  },
  {
    title: 'Премиум план',
    description: 'Подходит для растущих бизнесов и крупных компаний.',
    price: '$199',
    features: [
      'Премиальные материалы',
      'Разнообразие стилей',
      'Эксклюзивные скидки'
    ],
    bgColor: 'bg-green-100',
    textColor: 'text-green-800',
    buttonColor: 'from-green-600 to-teal-600',
    buttonText: 'Начать'
  },
  {
    title: 'Корпоративный план',
    description: 'Идеален для масштабных развертываний и кастомных решений.',
    price: 'Индивидуально',
    features: [
      'Индивидуальная инфраструктура',
      'Кастомные интеграции',
      'Выделенная команда поддержки'
    ],
    bgColor: 'bg-yellow-100',
    textColor: 'text-yellow-800',
    buttonColor: 'from-yellow-600 to-orange-600',
    buttonText: 'Связаться с продажами'
  }
];

const PricingSection = () => {
  return (
    <section className="bg-gradient-to-r from-purple-900 to-indigo-900 py-12">
      <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div className="text-center mb-12">
          <h2 className="text-4xl font-extrabold text-white sm:text-5xl">
            Выберите ваш план
          </h2>
          <p className="mt-4 text-xl text-purple-200">
            Откройте для себя мир качественной одежды с нашими уникальными предложениями.
          </p>
        </div>

        <div className="grid grid-cols-1 gap-8 sm:grid-cols-2 lg:grid-cols-3">
          {plans.map((plan, index) => (
            <div
              key={index}
              className={`bg-white bg-opacity-10 rounded-lg shadow-lg p-6 relative overflow-hidden`}
            >
              <div className={`absolute top-0 right-0 m-4`}>
                <span className={`inline-flex items-center px-3 py-1 rounded-full text-sm font-medium ${plan.bgColor} ${plan.textColor}`}>
                  {plan.title}
                </span>
              </div>
              <div className="mb-8">
                <h3 className="text-2xl font-semibold text-white">{plan.title}</h3>
                <p className="mt-4 text-purple-200">{plan.description}</p>
              </div>
              <div className="mb-8">
                <span className="text-5xl font-extrabold text-white">{plan.price}</span>
                <span className="text-xl font-medium text-purple-200">/мес</span>
              </div>
              <ul className="mb-8 space-y-4 text-purple-200">
                {plan.features.map((feature, index) => (
                  <li key={index} className="flex items-center">
                    <svg className="h-6 w-6 text-green-400 mr-2" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                      <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M5 13l4 4L19 7" />
                    </svg>
                    <span>{feature}</span>
                  </li>
                ))}
              </ul>
              <a
                href="#"
                className={`block w-full py-3 px-6 text-center rounded-md text-white font-medium bg-gradient-to-r ${plan.buttonColor} hover:from-purple-700 hover:to-indigo-700`}
              >
                {plan.buttonText}
              </a>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
}

export default PricingSection;
