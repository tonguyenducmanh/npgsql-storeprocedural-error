-- function dùng để test cần chạy
create schema if not exists test;

drop function if exists test.test_function();

create or replace
function test.test_function()
 returns boolean
 language plpgsql
as $function$
begin
return 
	true;
end
$function$
;
