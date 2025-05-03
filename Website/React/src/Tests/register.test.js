import { Builder, By, until } from 'selenium-webdriver';
import chrome from 'selenium-webdriver/chrome.js';

const registerTest = async () => {
    const driver = await new Builder().forBrowser('chrome').setChromeOptions(new chrome.Options()).build();

    try {
        await driver.get('http://localhost:5173/register');

        await driver.findElement(By.name('firstname')).sendKeys('John');
        await driver.findElement(By.name('lastname')).sendKeys('Doe');
        await driver.findElement(By.name('email')).sendKeys('johndoe@example.com');
        await driver.findElement(By.name('username')).sendKeys('johndoe123');
        await driver.findElement(By.name('password')).sendKeys('StrongPass123!');
        await driver.executeScript(`
            const dateInput = document.querySelector('input[name="dateOfBirth"]');
            const nativeInputValueSetter = Object.getOwnPropertyDescriptor(window.HTMLInputElement.prototype, 'value').set;
            nativeInputValueSetter.call(dateInput, '1990-01-01');
            dateInput.dispatchEvent(new Event('input', { bubbles: true }));
          `);
        await driver.findElement(By.name('address')).sendKeys('123 Test Street, Example');

        await driver.findElement(By.css('input[type="submit"]')).click();

        await driver.wait(until.urlContains('/verify'), 5000);
        console.log('Test Passed: Redirected to /verify');
    } catch (err) {
        console.error('Test Failed:', err.message);
    } finally {
        await driver.quit();
    }
};

registerTest();
