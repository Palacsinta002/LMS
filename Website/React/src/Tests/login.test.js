import { Builder, By, Key, until } from 'selenium-webdriver';
import chrome from 'selenium-webdriver/chrome.js';
import fs from 'fs';

async function registerTest() {
  let options = new chrome.Options();
  options.addArguments('--no-sandbox');
  options.addArguments('--disable-dev-shm-usage');
  options.addArguments('--headless');

  let driver = await new Builder()
    .forBrowser('chrome')
    .setChromeOptions(options)
    .build();

  try {
    await driver.get('http://localhost:5173/register');
    console.log("Page loaded successfully");

    const fields = {
      firstname: 'Test',
      lastname: 'User',
      email: 'testuser@example.com',
      username: 'testuser123',
      password: 'Test@12345',
      address: '123 Test Street'
    };

    for (const [name, value] of Object.entries(fields)) {
      await driver.findElement(By.name(name)).sendKeys(value);
      console.log(`Filled ${name} field`);
    }

    const dateField = await driver.findElement(By.name('dateOfBirth'));
    await dateField.clear();
    
    const dateFormats = [
      '2000-01-01',  
      '01.01.2000', 
      '01/01/2000',  
      '01012000',
      '2000.01.01',
      '2000/01/01' 
    ];

    let dateValid = false;
    for (const format of dateFormats) {
      try {
        await dateField.clear();
        await dateField.sendKeys(format);
        await driver.findElement(By.css('input[type="submit"]')).click();
        
        const currentUrl = await driver.getCurrentUrl();
        if (currentUrl.includes('/verify')) {
          dateValid = true;
          console.log(`Success with date format: ${format}`);
          break;
        }
        
        await driver.navigate().back();
      } catch (e) {
        console.log(`Date format ${format} didn't work, trying next`);
      }
    }

    if (!dateValid) {
      throw new Error("None of the date formats worked");
    }

    console.log("Registration successful! Redirected to verification.");

  } catch (error) {
    console.error("Test failed:", error);
    
    try {
      const enteredDate = await driver.findElement(By.name('dateOfBirth')).getAttribute('value');
      console.log("Date entered:", enteredDate);
      
      const pageSource = await driver.getPageSource();
      fs.writeFileSync('page-source.html', pageSource);
      console.log("Page source saved as page-source.html");
      
      await driver.takeScreenshot().then((image) => {
        fs.writeFileSync('error-screenshot.png', image, 'base64');
        console.log("Screenshot saved as error-screenshot.png");
      });
    } catch (e) {
      console.error("Error during debugging:", e);
    }
    
  } finally {
    await driver.quit();
  }
}

registerTest();