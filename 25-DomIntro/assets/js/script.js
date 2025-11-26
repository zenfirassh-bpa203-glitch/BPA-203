let style = document.createElement('style');
style.textContent = `
  * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }

  body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    min-height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 20px;
  }

  .card {
    background: white;
    border-radius: 20px;
    box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
    overflow: hidden;
    max-width: 400px;
    width: 100%;
    position: relative;
  }

  .image-container {
    position: relative;
    width: 100%;
    height: 250px;
    overflow: hidden;
  }

  .house-image {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }

  .heart-icon {
    position: absolute;
    top: 15px;
    right: 15px;
    width: 40px;
    height: 40px;
    background: white;
    border-radius: 50%;
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    transition: all 0.3s;
  }

  .heart-icon:hover {
    transform: scale(1.1);
    background: #ff6b6b;
  }

  .heart-icon svg {
    width: 20px;
    height: 20px;
    fill: none;
    stroke: #333;
    stroke-width: 2;
  }

  .heart-icon:hover svg {
    stroke: white;
    fill: white;
  }

  .card-content {
    padding: 25px;
  }

  .property-type {
    color: #666;
    font-size: 13px;
    font-weight: 600;
    letter-spacing: 1px;
    text-transform: uppercase;
    margin-bottom: 8px;
  }

  .price {
    font-size: 36px;
    font-weight: 700;
    color: #2c3e50;
    margin-bottom: 8px;
  }

  .address {
    color: #7f8c8d;
    font-size: 16px;
    margin-bottom: 20px;
  }

  .features {
    display: flex;
    gap: 30px;
    padding: 20px 0;
    border-top: 1px solid #ecf0f1;
    border-bottom: 1px solid #ecf0f1;
    margin-bottom: 20px;
  }

  .feature {
    display: flex;
    align-items: center;
    gap: 10px;
  }

  .feature-icon {
    width: 24px;
    height: 24px;
    color: #667eea;
  }

  .feature-text {
    display: flex;
    flex-direction: column;
  }

  .feature-number {
    font-size: 18px;
    font-weight: 600;
    color: #2c3e50;
  }

  .feature-label {
    font-size: 13px;
    color: #7f8c8d;
  }

  .realtor-label {
    color: #666;
    font-size: 12px;
    font-weight: 600;
    letter-spacing: 1px;
    text-transform: uppercase;
    margin-bottom: 15px;
  }

  .realtor-info {
    display: flex;
    align-items: center;
    gap: 15px;
  }

  .realtor-avatar {
    width: 50px;
    height: 50px;
    border-radius: 50%;
    object-fit: cover;
  }

  .realtor-details {
    display: flex;
    flex-direction: column;
  }

  .realtor-name {
    font-size: 18px;
    font-weight: 600;
    color: #2c3e50;
    margin-bottom: 4px;
  }

  .realtor-phone {
    color: #7f8c8d;
    font-size: 14px;
  }
`;
document.head.appendChild(style);

// Card container yaratmaq
let card = document.createElement('div');
card.className = 'card';

// Şəkil container
let imageContainer = document.createElement('div');
imageContainer.className = 'image-container';

// Ev şəkli
let houseImage = document.createElement('img');
houseImage.className = 'house-image';
houseImage.src = 'https://images.unsplash.com/photo-1580587771525-78b9dba3b914?w=800';
houseImage.alt = 'House';

// Ürək ikonu
let heartIcon = document.createElement('div');
heartIcon.className = 'heart-icon';
heartIcon.innerHTML = `
  <svg viewBox="0 0 24 24">
    <path d="M12 21.35l-1.45-1.32C5.4 15.36 2 12.28 2 8.5 2 5.42 4.42 3 7.5 3c1.74 0 3.41.81 4.5 2.09C13.09 3.81 14.76 3 16.5 3 19.58 3 22 5.42 22 8.5c0 3.78-3.4 6.86-8.55 11.54L12 21.35z"/>
  </svg>
`;

imageContainer.appendChild(houseImage);
imageContainer.appendChild(heartIcon);

// Card content
let cardContent = document.createElement('div');
cardContent.className = 'card-content';

// Property type
let propertyType = document.createElement('div');
propertyType.className = 'property-type';
propertyType.textContent = 'DETACHED HOUSE • 5Y OLD';

// Price
let price = document.createElement('div');
price.className = 'price';
price.textContent = '$750,000';

// Address
let address = document.createElement('div');
address.className = 'address';
address.textContent = '742 Evergreen Terrace';

// Features container
let features = document.createElement('div');
features.className = 'features';

// Bedroom feature
let bedroomFeature = document.createElement('div');
bedroomFeature.className = 'feature';
bedroomFeature.innerHTML = `
  <svg class="feature-icon" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
    <rect x="3" y="11" width="18" height="10" rx="2"/>
    <path d="M7 11V7a2 2 0 0 1 2-2h6a2 2 0 0 1 2 2v4"/>
  </svg>
  <div class="feature-text">
    <span class="feature-number">3</span>
    <span class="feature-label">Bedrooms</span>
  </div>
`;

// Bathroom feature
let bathroomFeature = document.createElement('div');
bathroomFeature.className = 'feature';
bathroomFeature.innerHTML = `
  <svg class="feature-icon" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
    <path d="M9 6l6 6l-6 6"/>
    <path d="M4 12h16"/>
    <rect x="6" y="16" width="12" height="4" rx="1"/>
  </svg>
  <div class="feature-text">
    <span class="feature-number">2</span>
    <span class="feature-label">Bathrooms</span>
  </div>
`;

features.appendChild(bedroomFeature);
features.appendChild(bathroomFeature);

// Realtor section
let realtorLabel = document.createElement('div');
realtorLabel.className = 'realtor-label';
realtorLabel.textContent = 'REALTOR';

let realtorInfo = document.createElement('div');
realtorInfo.className = 'realtor-info';

let realtorAvatar = document.createElement('img');
realtorAvatar.className = 'realtor-avatar';
realtorAvatar.src = 'https://res.cloudinary.com/dz6nnbmyw/image/upload/v1764137818/WhatsApp_Image_2025-11-26_at_10.03.30_e9nvqa.jpg';
realtorAvatar.alt = 'Sireliyeva Zenfira';

let realtorDetails = document.createElement('div');
realtorDetails.className = 'realtor-details';

let realtorName = document.createElement('div');
realtorName.className = 'realtor-name';
realtorName.textContent = 'Sireliyeva Zenfira';

let realtorPhone = document.createElement('div');
realtorPhone.className = 'realtor-phone';
realtorPhone.textContent = '(555) 555-4321';

realtorDetails.appendChild(realtorName);
realtorDetails.appendChild(realtorPhone);
realtorInfo.appendChild(realtorAvatar);
realtorInfo.appendChild(realtorDetails);

// Hər şeyi birləşdirmək
cardContent.appendChild(propertyType);
cardContent.appendChild(price);
cardContent.appendChild(address);
cardContent.appendChild(features);
cardContent.appendChild(realtorLabel);
cardContent.appendChild(realtorInfo);

card.appendChild(imageContainer);
card.appendChild(cardContent);

document.body.appendChild(card);

// Heart icon click eventi
heartIcon.addEventListener('click', function() {
  this.style.background = this.style.background === 'rgb(255, 107, 107)' ? 'white' : '#ff6b6b';
});