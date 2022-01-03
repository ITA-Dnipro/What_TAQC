using OpenQA.Selenium;

namespace ConsoleApp1.Secretaries
{
    class Locators
    {
        public By
            sidebarSecretary = By.XPath("//*[@id=\"root\"]/div/nav/div[2]/div/a[3]/span"),
            tableButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[1]/div/button[1]"),
            cardsButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div[1]/div[1]/div/button[1]"),
            searchField = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[2]/div/input"),
            secretaryNotFoundLabel = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/tbody/tr/td"),
            addButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[5]/button"),
            detailsButtonTable = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/tbody/tr[1]/td[4]/svg"),
            detailsButtonCards = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div[2]/div[1]/div/div[1]/button"),
            editButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/tbody/tr[1]/td[4]/svg"),
            rowsSelected = By.XPath("//*[@id=\"change-visible-people\"]"),
            disabledCheckbox = By.XPath("//*[@id=\"switchDisabled\"]"),
            countSecretaryLabel = By.XPath("//*[@id=\"root\"]/div/div/div[1]/span"),
            sortArrowName = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/thead/tr/th[1]/span"),
            sortArrowSurname = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/thead/tr/th[2]/span"),
            sortArrowEmail = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/thead/tr/th[3]/span"),
            paginationArrowLeft = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/nav/ul[1]/li/button"),
            paginationArrowRight = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/nav/ul[3]/li/button"),
            backButton = By.XPath("//*[@id=\"root\"]/div/div/div[1]/a[1]/svg"),
            saveButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div/div/div/div/form/div/div[4]/div[3]/button"),
            resetButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div/div/div/div/form/div/div[4]/div[2]/button"),
            LayOffButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div/div/div/div/form/div/div[4]/div[1]/button"),
            titleLabelEdit = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div/div/div/div/h3"),
            titleLabelDetails = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div/div/div/div/h3"),
            elementsInTable = By.XPath("//tr[@class = 'list-of-lessons__table-row___16_kJ']");
    }
}
