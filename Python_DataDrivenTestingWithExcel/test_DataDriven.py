import openpyxl
import pytest

from utilities import ExcelReader


@pytest.mark.parametrize("username, password", ExcelReader.get_data_from_excel("ExcelFiles/loginTest.xlsx", "LoginTest"))
def test_login(username, password):
    print("Logged In Via Username: " +username + " Password: "+password)