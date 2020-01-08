SELECT 套娃超大.套娃大 AS 套娃超大
FROM (
	SELECT 套娃大.套娃中 AS 套娃大
	FROM (
		SELECT 套娃中.套娃小 AS 套娃中
		FROM (
			SELECT 套娃小.套娃迷你 AS 套娃小
			FROM (
				SELECT '禁止套娃' AS 套娃迷你
				FROM DUAL 套娃迷你
			) 套娃小
		) 套娃中
	) 套娃大
) 套娃超大
