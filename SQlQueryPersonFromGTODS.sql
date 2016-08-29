SELECT P.* ,PA.SP_EMP_ADDR1 AS PrsnCapabilityPrimary,  PA.SP_EMP_ADDR4 AS PrsnCapabilitySecondary   FROM vw_GTEmployee P (NOLOCK)
JOIN PAEMPLOYEE PA (NOLOCK) ON P.EmployeeNumber = PA.Employee
ORDER BY P.EmployeeNumber FOR XML AUTO, TYPE, ELEMENTS