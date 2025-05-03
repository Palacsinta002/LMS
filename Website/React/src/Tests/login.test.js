import { Builder, By, Key, until } from 'selenium-webdriver';
import chrome from 'selenium-webdriver/chrome.js';

async function loginTest() {
  let options = new chrome.Options();
  options.addArguments('--no-sandbox');

  let driver = await new Builder().forBrowser('chrome').setChromeOptions(options).build();
  try {
    await driver.get('http://localhost:5173/login');

    await driver.findElement(By.name('username')).sendKeys('johndoe');
    await driver.findElement(By.name('password')).sendKeys('password123', Key.RETURN);

    await driver.wait(until.elementLocated(By.css('.dashboard')), 5000);

    console.log("Login successful!");
  } catch (error) {
    console.error("Test failed:", error);
  } finally {
    await driver.quit();
  }
}

loginTest();