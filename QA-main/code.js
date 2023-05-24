package Others;
import java.util.concurrent.TimeUnit;


import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;





public class authentication {
       public WebDriver driver;
       @Test
       public void testBasicAuth() {
              
              driver.get("http://admin:admin@the-internet.herokuapp.com/basic_auth");
              String actualText=driver.findElement(By.xpath("//div[@class='example']/p")).getText();
              Assert.assertEquals(actualText, "Congratulations! You must have the proper credentials.");
              System.out.println("Passed");
       }
       
       
       
       
       
       @BeforeClass
       public void beforeClass() {
              System.setProperty("webdriver.chrome.driver", "D:\\Softwares\\chromedriver_win32\\chromedriver.exe");      
              driver = new ChromeDriver();
              driver.manage().window().maximize();
              driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
       }




       @AfterClass
       public void afterClass() {
              driver.quit();
       }


}
